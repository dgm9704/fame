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
            => new AIFMReportingInfo().ToFile("manager_out.xml");

        [Fact]
        public void ImportManager()
            => AIFMReportingInfo.FromFile("AIFMSample.xml");

        [Fact]
        public void ExportFund()
            => new AIFReportingInfo().ToFile("fund_out.xml");

        [Fact]
        public void ImportFund()
            => AIFReportingInfo.FromFile("AIFSample.xml");
     }
}
