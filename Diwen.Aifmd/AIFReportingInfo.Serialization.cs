namespace Diwen.Aifmd
{
    using System;
    using System.IO;
    using System.Xml.Serialization;

    public partial class AIFReportingInfo
    {
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
    }
}