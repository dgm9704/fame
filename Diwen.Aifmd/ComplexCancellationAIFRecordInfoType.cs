namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCancellationAIFRecordInfoType
    {
        public string CancelledAIFNationalCode {get; set;}
        public string CancelledAIFMNationalCode {get; set;}

        public ReportingPeriodTypeType CancelledReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string CancelledReportingPeriodYear {get; set;}

        public CancelledRecordFlagType CancelledRecordFlag {get; set;}
    }
}
