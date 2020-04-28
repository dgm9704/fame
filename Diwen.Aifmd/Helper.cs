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

namespace Diwen.Aifmd
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using System.Xml.XPath;

    public partial class Helper
    {
        public static XElement ElementFromPath(XDocument document, string path)
        {
            if (document == null)
                throw new ArgumentNullException("document");

            if (path == null)
                throw new ArgumentNullException("path");

            var parts = path.Split('.');

            var node = document.XPathSelectElement(parts[0]);
            if (node == null)
            {
                document.Add(new XElement(parts[0]));
                node = document.XPathSelectElement(parts[0]);
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
                        node.Add(new XElement(part));
                    }

                    next = node.XPathSelectElement(part);
                }
                node = next;
            }
            return node;
        }

        public static XAttribute AttributeFromPath(XDocument document, string path)
        {
            if (document == null)
                throw new ArgumentNullException(nameof(document));

            if (path == null)
                throw new ArgumentNullException(nameof(path));

            var parts = path.Split('.', '@');

            var node = document.XPathSelectElement(parts[0]);
            if (node == null)
            {
                document.Add(new XElement(parts[0]));
                node = document.XPathSelectElement(parts[0]);
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
                        node.Add(new XElement(part));
                    }

                    next = node.XPathSelectElement(part);
                }
                node = next;
            }
            var attribute = new XAttribute(parts.Last(), string.Empty);
            node.Add(attribute);
            return attribute;
        }

        public static string GetPath(XElement element)
        {
            if (element == null)
                throw new ArgumentNullException(nameof(element));

            var path = element.Name.LocalName;

            if (element.Parent != null)
            {
                int idx;
                var siblings = element.Parent.Elements(element.Name).ToList();
                if (siblings.Count != 1)
                {
                    idx = siblings.IndexOf(element) + 1;
                    if (idx != 0)
                        path += "[" + idx + "]";
                }
                path = GetPath(element.Parent) + "." + path;
            }
            return path;
        }

        public static string GetPath(XAttribute attribute)
        {
            if (attribute == null)
                throw new ArgumentNullException(nameof(attribute));

            var path = attribute.Name.LocalName;

            if (attribute.Parent != null)
                path = GetPath(attribute.Parent) + "@" + path;

            return path;
        }

    }
}
