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
                    l => Helper.GetPath(l),
                    l => l.Value);

            return result;
        }

        public static XDocument WriteReport(Dictionary<string, string> data)
        {
            var report = new XDocument();
            foreach (var item in data)
            {
                var node = Helper.ElementFromPath(report, item.Key);
                node.Value = item.Value;
            }
            return report;
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
