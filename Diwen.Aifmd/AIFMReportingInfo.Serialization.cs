namespace Diwen.Aifmd
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public partial class AIFMReportingInfo
    {
        private static Lazy<XmlSerializer> Serializer = new Lazy<XmlSerializer>(()
            => new XmlSerializer(typeof(AIFMReportingInfo)));

        public static AIFMReportingInfo FromFile(string path)
        {
            using (var file = new FileStream(path, FileMode.Open))
                return (AIFMReportingInfo)Serializer.Value.Deserialize(file);
        }

        public void ToFile(string path)
            => ToFile(this, path);

        private void ToFile(AIFMReportingInfo report, string path)
        {
            using (var file = new FileStream(path, FileMode.Create))
                Serializer.Value.Serialize(file, report);
        }

    }
}