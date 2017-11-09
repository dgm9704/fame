namespace Diwen.Aifmd.Test
{
    using System.Xml.Linq;
    using System.Xml.Serialization;
    using Diwen.Aifmd;
    using Xunit;

    public class ExportTests
    {
        [Fact]
        public static void Export()
        {
            var a = XDocument.Load("manager_mixed.xml");
            using (var reader = a.CreateReader())
            {
                var serializer = new XmlSerializer(typeof(AIFMReportingInfo));
                var b = (AIFMReportingInfo)serializer.Deserialize(reader);
                b.ToFile("manager_from_xdocument.xml");
            }
        }
    }
}