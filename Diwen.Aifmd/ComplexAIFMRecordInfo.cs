namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFMRecordInfo
    {

        public FilingType FilingType {get; set;}

        public AIFMContentType AIFMContentType {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodStartDate {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodEndDate {get; set;}

        public ReportingPeriodType ReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string ReportingPeriodYear {get; set;}

        public ReportingObligationChangeFrequencyCode AIFMReportingObligationChangeFrequencyCode {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeFrequencyCodeSpecified {get; set;}

        public AIFMReportingObligationChangeContentsCode AIFMReportingObligationChangeContentsCode {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeContentsCodeSpecified {get; set;}

        public ReportingObligationChangeQuarter AIFMReportingObligationChangeQuarter {get; set;}

        [XmlIgnore]
        public bool AIFMReportingObligationChangeQuarterSpecified {get; set;}

        public bool LastReportingFlag {get; set;}

        [XmlArrayItem("Assumption", IsNullable = false)]
        public ComplexAssumption[] Assumptions {get; set;}

        public AIFMReportingCode AIFMReportingCode {get; set;}

        public string AIFMJurisdiction {get; set;}

        public string AIFMNationalCode {get; set;}

        public string AIFMName {get; set;}

        public bool AIFMEEAFlag {get; set;}

        public bool AIFMNoReportingFlag {get; set;}

        public ComplexAIFMCompleteDescription AIFMCompleteDescription {get; set;}
    }
}
