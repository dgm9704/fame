namespace Diwen.Aifmd.Test
{
    using Xunit;
    using Diwen.Aifmd;
    using System.Xml.Serialization;
    using System.IO;

    public class Sampletests
    {
        [Fact]
        public void ExportManager()
        {
            var path = "manager_out.xml";
            var manager = new AIFMReportingInfo();
            var serializer = new XmlSerializer(typeof(AIFMReportingInfo));
            using (var file = new FileStream(path, FileMode.Create))
                serializer.Serialize(file, manager);
        }

        [Fact]
        public void ImportManager()
        {
            var path = "AIFMSample.xml";
            var serializer = new XmlSerializer(typeof(AIFMReportingInfo));
            AIFMReportingInfo manager = null;
            using (var file = new FileStream(path, FileMode.Open))
                manager = (AIFMReportingInfo)serializer.Deserialize(file);

        }

        [Fact]
        public void ExportFund()
        {
            var path = "fund_out.xml";
            var manager = new AIFReportingInfo();
            var serializer = new XmlSerializer(typeof(AIFReportingInfo));
            using (var file = new FileStream(path, FileMode.Create))
                serializer.Serialize(file, manager);
        }

        [Fact]
        public void ImportFund()
        {
            var path = "AIFSample.xml";
            var serializer = new XmlSerializer(typeof(AIFReportingInfo));
            AIFReportingInfo manager = null;
            using (var file = new FileStream(path, FileMode.Open))
                manager = (AIFReportingInfo)serializer.Deserialize(file);

        }
    }
}
