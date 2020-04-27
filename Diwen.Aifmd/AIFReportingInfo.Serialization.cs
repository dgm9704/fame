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

    public partial class AIFReportingInfo
    {

        static AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();
        static Version version = assembly.Version;
        static string id = assembly.Name;

        private static Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(()
            => new XmlSerializer(typeof(AIFReportingInfo)));

        public static AIFReportingInfo FromFile(string path)
        {
            using (var file = new FileStream(path, FileMode.Open))
                return (AIFReportingInfo)Serializer.Value.Deserialize(file);
        }

        public void ToFile(string path)
            => ToFile(this, path);

        private void ToFile(AIFReportingInfo report, string path)
        {
            using (var file = new FileStream(path, FileMode.Create))
                Serializer.Value.Serialize(file, report);
        }

        public Dictionary<string, string> GetRecords()
        {
            var document = this.ToXDocument();
            var result = new Dictionary<string, string>();
            result =
                document.
                Descendants().
                Where(d => !d.Descendants().Any()).
                ToDictionary(
                    l => GetPath(l),
                    l => l.Value);

            return result;
        }

        public static XDocument WriteReport(Dictionary<string, string> data)
        {
            var report = new XDocument();
            foreach (var item in data)
            {
                var node = ElementFromPath(report, item.Key);
                node.Value = item.Value;
            }
            return report;
        }

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

        public static string GetPath(XElement element)
        {
            if (element == null)
                throw new ArgumentNullException("element");

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

        public XDocument ToXDocument()
        => XDocument.Parse(this.ToXml());

        void ToXmlWriter(XmlWriter writer)
        {
            var ns = new XmlSerializerNamespaces();
            var info = $" {id} {version} ";
            Serializer.Value.Serialize(writer, this, ns);
            writer.WriteComment(info);
        }

        public XmlDocument ToXmlDocument()
        {
            var document = new XmlDocument();
            var declaration = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(declaration);
            var nav = document.CreateNavigator();

            using (var writer = nav.AppendChild())
                ToXmlWriter(writer);

            return document;
        }

        public string ToXml()
        => ToXmlDocument().OuterXml;
    }
}
