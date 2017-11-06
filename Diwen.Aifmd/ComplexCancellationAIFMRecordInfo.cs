namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCancellationAIFMRecordInfo
    {

        public string CancelledAIFMNationalCode {get; set;}

        public ReportingPeriodType CancelledReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string CancelledReportingPeriodYear {get; set;}

        public CancelledRecordFlag CancelledRecordFlag {get; set;}
    }
}
