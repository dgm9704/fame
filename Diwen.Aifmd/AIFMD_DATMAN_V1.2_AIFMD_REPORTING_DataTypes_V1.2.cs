namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AIFMReportingInfo
    {





        [XmlElement("AIFMRecordInfo", typeof(ComplexAIFMRecordInfoType))]
        [XmlElement("CancellationAIFMRecordInfo", typeof(ComplexCancellationAIFMRecordInfoType))]
        public object[] Items {get; set;}

        [XmlAttribute]
        public string ReportingMemberState {get; set;}

        [XmlAttribute]
        public string Version {get; set;}

        [XmlAttribute]
        public DateTime CreationDateAndTime {get; set;}
    }

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

    [Serializable]
    public enum FilingTypeType
    {

        AMND,

        INIT,
    }

    [Serializable]
    public enum AIFMContentTypeType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,
    }

    [Serializable]
    public enum ReportingPeriodTypeType
    {

        Q1,

        Q2,

        Q3,

        Q4,

        H1,

        H2,

        Y1,

        X1,

        X2,
    }

    [Serializable]
    public enum ReportingObligationChangeFrequencyCodeType
    {

        YH,

        YQ,

        HY,

        HQ,

        QY,

        QH,

        NQ,

        NH,

        NY,
    }

    [Serializable]
    public enum AIFMReportingObligationChangeContentsCodeType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        [XmlEnum("6")]
        Item6,
    }

    [Serializable]
    public enum ReportingObligationChangeQuarterType
    {

        Q1,

        Q2,

        Q3,

        Q4,
    }

    [Serializable]
    public partial class ComplexAssumptionType
    {



        [XmlElement(DataType = "integer")]
        public string QuestionNumber {get; set;}

        public string AssumptionDescription {get; set;}
    }

    [Serializable]
    public partial class ComplexBaseCurrencyDescriptionType
    {








        public string BaseCurrency {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInBaseCurrency {get; set;}

        public FXEURReferenceRateTypeType FXEURReferenceRateType {get; set;}

        [XmlIgnore]
        public bool FXEURReferenceRateTypeSpecified {get; set;}

        public decimal FXEURRate {get; set;}

        [XmlIgnore]
        public bool FXEURRateSpecified {get; set;}

        public string FXEUROtherReferenceRateDescription {get; set;}
    }

    [Serializable]
    public enum FXEURReferenceRateTypeType
    {

        ECB,

        OTH,
    }

    [Serializable]
    public partial class ComplexPrincipalInstrumentType
    {




        public FiveRankingType Ranking {get; set;}

        public SubAssetTypeType SubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }

    [Serializable]
    public enum SubAssetTypeType
    {

        SEC_CSH_CODP,

        SEC_CSH_COMP,

        SEC_CSH_OTHD,

        SEC_CSH_OTHC,

        SEC_LEQ_IFIN,

        SEC_LEQ_OTHR,

        SEC_UEQ_UEQY,

        SEC_CPN_INVG,

        SEC_CPN_NIVG,

        SEC_CPI_INVG,

        SEC_CPI_NIVG,

        SEC_SBD_EUBY,

        SEC_SBD_EUBM,

        SEC_SBD_NOGY,

        SEC_SBD_NOGM,

        SEC_SBD_EUGY,

        SEC_SBD_EUGM,

        SEC_MBN_MNPL,

        SEC_CBN_INVG,

        SEC_CBN_NIVG,

        SEC_CBI_INVG,

        SEC_CBI_NIVG,

        SEC_LON_LEVL,

        SEC_LON_OTHL,

        SEC_SSP_SABS,

        SEC_SSP_RMBS,

        SEC_SSP_CMBS,

        SEC_SSP_AMBS,

        SEC_SSP_ABCP,

        SEC_SSP_CDOC,

        SEC_SSP_STRC,

        SEC_SSP_SETP,

        SEC_SSP_OTHS,

        DER_EQD_FINI,

        DER_EQD_OTHD,

        DER_FID_FIXI,

        DER_CDS_SNFI,

        DER_CDS_SNSO,

        DER_CDS_SNOT,

        DER_CDS_INDX,

        DER_CDS_EXOT,

        DER_CDS_OTHR,

        DER_FEX_INVT,

        DER_FEX_HEDG,

        DER_IRD_INTR,

        DER_CTY_ECOL,

        DER_CTY_ENNG,

        DER_CTY_ENPW,

        DER_CTY_ENOT,

        DER_CTY_PMGD,

        DER_CTY_PMOT,

        DER_CTY_OTIM,

        DER_CTY_OTLS,

        DER_CTY_OTAP,

        DER_CTY_OTHR,

        DER_OTH_OTHR,

        PHY_RES_RESL,

        PHY_RES_COML,

        PHY_RES_OTHR,

        PHY_CTY_PCTY,

        PHY_TIM_PTIM,

        PHY_ART_PART,

        PHY_TPT_PTPT,

        PHY_OTH_OTHR,

        CIU_OAM_MMFC,

        CIU_OAM_AETF,

        CIU_OAM_OTHR,

        CIU_NAM_MMFC,

        CIU_NAM_AETF,

        CIU_NAM_OTHR,

        OTH_OTH_OTHR,

        NTA_NTA_NOTA,
    }

    [Serializable]
    public partial class ComplexMarketIdentificationWithNOTType
    {



        public MarketCodeTypeWithNOTType MarketCodeType {get; set;}

        public string MarketCode {get; set;}
    }

    [Serializable]
    public enum MarketCodeTypeWithNOTType
    {

        NOT,

        MIC,

        OTC,

        XXX,
    }

    [Serializable]
    public partial class ComplexFivePrincipalMarketType
    {




        public FiveRankingType Ranking {get; set;}

        public ComplexMarketIdentificationWithNOTType MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }

    [Serializable]
    public partial class ComplexAIFMNationalIdentifierType
    {



        public string ReportingMemberState {get; set;}

        public string AIFMNationalCode {get; set;}
    }

    [Serializable]
    public partial class ComplexAIFMIdentifierType
    {




        public string AIFMIdentifierLEI {get; set;}

        public string AIFMIdentifierBIC {get; set;}

        public ComplexAIFMNationalIdentifierType OldAIFMIdentifierNCA {get; set;}
    }

    [Serializable]
    public partial class ComplexAIFMCompleteDescriptionType
    {






        public ComplexAIFMIdentifierType AIFMIdentifier {get; set;}

        [XmlArrayItem("AIFMFivePrincipalMarket", IsNullable = false)]
        public ComplexFivePrincipalMarketType[] AIFMPrincipalMarkets {get; set;}

        [XmlArrayItem("AIFMPrincipalInstrument", IsNullable = false)]
        public ComplexPrincipalInstrumentType[] AIFMPrincipalInstruments {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInEuro {get; set;}

        public ComplexBaseCurrencyDescriptionType AIFMBaseCurrencyDescription {get; set;}
    }

    [Serializable]
    public partial class ComplexCancellationAIFMRecordInfoType
    {





        public string CancelledAIFMNationalCode {get; set;}

        public ReportingPeriodTypeType CancelledReportingPeriodType {get; set;}

        [XmlElement(DataType = "gYear")]
        public string CancelledReportingPeriodYear {get; set;}

        public CancelledRecordFlagType CancelledRecordFlag {get; set;}
    }

    [Serializable]
    public enum CancelledRecordFlagType
    {

        C,

        D,
    }

    [Serializable]
    public enum AIFMReportingCodeType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,

        [XmlEnum("6")]
        Item6,

        [XmlEnum("7")]
        Item7,

        [XmlEnum("8")]
        Item8,

        [XmlEnum("9")]
        Item9,
    }
}
