namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFMRecordInfoType
    {

        public FilingTypeType FilingType {get; set;}

        public AIFMContentTypeType AIFMContentType {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodStartDate {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodEndDate {get; set;}

        public ReportingPeriodTypeType ReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string ReportingPeriodYear {get; set;}

        public ReportingObligationChangeFrequencyCodeType AIFMReportingObligationChangeFrequencyCode {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeFrequencyCodeSpecified {get; set;}

        public AIFMReportingObligationChangeContentsCodeType AIFMReportingObligationChangeContentsCode {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeContentsCodeSpecified {get; set;}

        public ReportingObligationChangeQuarterType AIFMReportingObligationChangeQuarter {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeQuarterSpecified {get; set;}

        public bool LastReportingFlag {get; set;}

        [XmlArrayItem("Assumption", IsNullable = false)]
        public ComplexAssumptionType[] Assumptions {get; set;}

        public AIFMReportingCodeType AIFMReportingCode {get; set;}

        public string AIFMJurisdiction {get; set;}

        public string AIFMNationalCode {get; set;}

        public string AIFMName {get; set;}

        public bool AIFMEEAFlag {get; set;}

        public bool AIFMNoReportingFlag {get; set;}

        public ComplexAIFMCompleteDescriptionType AIFMCompleteDescription {get; set;}
    }
}
