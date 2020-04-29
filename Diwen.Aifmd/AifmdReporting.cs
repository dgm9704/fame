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
    using Diwen.Aifmd.Extensions;

    public class AifmdReporting
    {
        static AssemblyName assembly = Assembly.GetExecutingAssembly().GetName();

        static string VersionComment = $" {assembly.Name} {assembly.Version} ";

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

        private static Dictionary<Type, XmlSerializer> serializers
        = new Dictionary<Type, XmlSerializer>();

        private static XmlSerializer GetSerializer(Type type)
        {
            if (!serializers.ContainsKey(type))
                serializers.Add(type, new XmlSerializer(type));
            return serializers[type];
        }

        private static T FromStream<T>(Stream stream) where T : AifmdReporting
        => (T)GetSerializer<T>().Deserialize(stream);

        private static XmlSerializer GetSerializer<T>() where T : AifmdReporting
        => GetSerializer(typeof(T));

        internal static T FromFile<T>(string path) where T : AifmdReporting
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                return FromStream<T>(stream);
        }

        internal static void ToFile<T>(T report, string path) where T : AifmdReporting
        {
            Directory.CreateDirectory(Path.GetDirectoryName(path));
            using (var writer = XmlWriter.Create(path, XmlWriterSettings))
            {
                ToXmlWriter(writer, report);
                writer.WriteComment(VersionComment);
            }
        }

        private static void ToXmlWriter<T>(XmlWriter writer, T header) where T : AifmdReporting
        => GetSerializer<T>().Serialize(writer, header);

        internal static XmlDocument ToXmlDocument<T>(T report) where T : AifmdReporting
        {
            var document = new XmlDocument();
            var navigator = document.CreateNavigator();
            using (XmlWriter writer = navigator.AppendChild())
            {
                GetSerializer<T>().Serialize(writer, report);
                writer.WriteComment(VersionComment);
            }

            return document;
        }

        internal static T FromXDocument<T>(XDocument document) where T : AifmdReporting
        {
            using (var reader = document.CreateReader())
                return (T)GetSerializer<T>().Deserialize(reader);
        }

        private static XDocument ToXDocument<T>(T report) where T : AifmdReporting
        => XDocument.Parse(ToXml(report));

        private static string ToXml<T>(T report) where T : AifmdReporting
        => ToXmlDocument<T>(report).OuterXml;

        internal static Dictionary<string, string> GetData<T>(T report) where T : AifmdReporting
        => ToXDocument(report).GetData();
    }
}