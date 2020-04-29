//
//  This file is part of Diwen.Aifmd
//
//  Author:
//       John Nordberg <john.nordberg@gmail.com>
//
//  Copyright (c) 2017-2020 John Nordberg
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have received a copy of the GNU Lesser General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace Diwen.Aifmd.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using System.Xml.XPath;

    public static class XDocumentExtensions
    {

        public static void ReadData(this XDocument document, Dictionary<string, string> data)
        {
            foreach (var item in data)
                if (item.Key.IndexOf("@") != -1)
                    document.WriteAttribute(item.Key, item.Value);
                else
                    document.WriteElement(item.Key, item.Value);
        }

        public static void WriteElement(this XDocument document, string path, string value)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            if (path == null)
                throw new ArgumentNullException(nameof(path));

            var parts = path.Split('.');

            var node = document.XPathSelectElement(parts[0]);
            if (node == null)
            {
                node = new XElement(parts[0]);
                document.Add(node);
            }

            for (int i = 1; i < parts.Length; i++)
            {
                var part = parts[i];
                var next = node.XPathSelectElement(part);

                if (next == null)
                {
                    var x = part.IndexOf('[');
                    if (x != -1)
                    {
                        var p = part.Remove(x);
                        do
                        {
                            node.Add(new XElement(p));
                            next = node.XPathSelectElement(part);
                        } while (next == null);
                    }
                    else
                    {
                        next = new XElement(part);
                        node.Add(next);
                    }
                }
                node = next;
            }
            node.Value = value;
        }

        public static void WriteAttribute(this XDocument document, string path, string value)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            if (path == null)
                throw new ArgumentNullException(nameof(path));

            var parts = path.Split('.', '@');

            var node = document.XPathSelectElement(parts[0]);
            if (node == null)
            {
                node = new XElement(parts[0]);
                document.Add(node);
            }

            for (int i = 1; i < parts.Length - 1; i++)
            {
                var part = parts[i];
                var next = node.XPathSelectElement(part);

                if (next == null)
                {
                    var x = part.IndexOf('[');
                    if (x != -1)
                    {
                        var p = part.Remove(x);
                        do
                        {
                            node.Add(new XElement(p));
                            next = node.XPathSelectElement(part);
                        } while (next == null);
                    }
                    else
                    {
                        next = new XElement(part);
                        node.Add(next);
                    }
                }
                node = next;
            }
            var attribute = new XAttribute(parts.Last(), value);
            node.Add(attribute);
        }

        public static Dictionary<string, string> GetData(this XDocument document)
        {
            var data = new Dictionary<string, string>();

            var attributes =
                document.
                Descendants().
                SelectMany(d => d.Attributes()).
                Where(a => !a.IsNamespaceDeclaration);

            var elements =
                document.
                Descendants().
                Where(d => !d.Descendants().Any());

            foreach (var attribute in attributes)
                data[attribute.GetPath()] = attribute.Value;

            foreach (var element in elements)
                data[element.GetPath()] = element.Value;

            return data;
        }
    }
}