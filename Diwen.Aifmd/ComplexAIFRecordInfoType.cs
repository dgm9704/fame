namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFRecordInfoType
    {
        public FilingTypeType FilingType {get; set;}

        public AIFContentType AIFContentType {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodStartDate {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodEndDate {get; set;}

        public ReportingPeriodTypeType ReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string ReportingPeriodYear {get; set;}

        public ReportingObligationChangeFrequencyCodeType AIFReportingObligationChangeFrequencyCode {get; set;}

        [XmlIgnore]
        public bool AIFReportingObligationChangeFrequencyCodeSpecified {get; set;}
        public AIFReportingObligationChangeContentsCode AIFReportingObligationChangeContentsCode {get; set;}

        [XmlIgnore]
        public bool AIFReportingObligationChangeContentsCodeSpecified {get; set;}

        public ReportingObligationChangeQuarterType AIFReportingObligationChangeQuarter {get; set;}

        [XmlIgnore]
        public bool AIFReportingObligationChangeQuarterSpecified {get; set;}
        public bool LastReportingFlag {get; set;}

        [XmlArrayItem("Assumption", IsNullable = false)]
        public ComplexAssumptionType[] Assumptions {get; set;}

        public string AIFMNationalCode {get; set;}

        public string AIFNationalCode {get; set;}
        public string AIFName {get; set;}

        public bool AIFEEAFlag {get; set;}

        public AIFReportingCodeType AIFReportingCode {get; set;}

        public string AIFDomicile {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime InceptionDate {get; set;}

        public bool AIFNoReportingFlag {get; set;}

        public ComplexAIFCompleteDescriptionType AIFCompleteDescription {get; set;}
    }
}
