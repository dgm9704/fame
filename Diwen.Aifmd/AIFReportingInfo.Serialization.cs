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
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Serialization;

    public partial class AIFReportingInfo
    {

        static AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();
        static Version version = assembly.Version;
        static string id = assembly.Name;

        private static Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(()
            => new XmlSerializer(typeof(AIFReportingInfo)));

        static XmlWriterSettings XmlWriterSettings = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "\t",
            NamespaceHandling = NamespaceHandling.OmitDuplicates,
            Encoding = Encoding.UTF8
        };

        static XmlReaderSettings XmlReaderSettings = new XmlReaderSettings
        {
            IgnoreWhitespace = true,
            IgnoreProcessingInstructions = true,
            IgnoreComments = true,
            XmlResolver = null,
            ValidationType = ValidationType.None
        };

        public static AIFReportingInfo FromFile(string path)
        {
            using (var file = new FileStream(path, FileMode.Open))
                return FromStream(file);
        }

        public static AIFReportingInfo FromStream(Stream stream)
        {
            AIFReportingInfo report;
            using (var reader = XmlReader.Create(stream, XmlReaderSettings))
                report = (AIFReportingInfo)Serializer.Value.Deserialize(reader);

            return report;
        }

        public void ToFile(string path)
        {
            using (var writer = XmlWriter.Create(path, XmlWriterSettings))
                ToXmlWriter(writer);
        }

        public Dictionary<string, string> GetData()
        {
            var document = this.ToXDocument();
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
                data[Helper.GetPath(attribute)] = attribute.Value;

            foreach (var element in elements)
                data[Helper.GetPath(element)] = element.Value;

            return data;
        }

        public static AIFReportingInfo FromData(Dictionary<string, string> data)
        {
            var document = new XDocument();
            foreach (var item in data)
                if (item.Key.IndexOf("@") != -1)
                    Helper.WriteAttribute(document, item.Key, item.Value);
                else
                    Helper.WriteElement(document, item.Key, item.Value);

            return AIFReportingInfo.FromXDocument(document);

        }

        public static AIFReportingInfo FromXDocument(XDocument document)
        {
            using (var reader = document.CreateReader())
                return (AIFReportingInfo)Serializer.Value.Deserialize(reader);
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
