namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AIFMReportingInfo
    {

        private object[] itemsField;

        private string reportingMemberStateField;

        private string versionField;

        private DateTime creationDateAndTimeField;

        [XmlElement("AIFMRecordInfo", typeof(ComplexAIFMRecordInfoType))]
        [XmlElement("CancellationAIFMRecordInfo", typeof(ComplexCancellationAIFMRecordInfoType))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        [XmlAttribute]
        public string ReportingMemberState
        {
            get
            {
                return this.reportingMemberStateField;
            }
            set
            {
                this.reportingMemberStateField = value;
            }
        }

        [XmlAttribute]
        public string Version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        [XmlAttribute]
        public DateTime CreationDateAndTime
        {
            get
            {
                return this.creationDateAndTimeField;
            }
            set
            {
                this.creationDateAndTimeField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFMRecordInfoType
    {

        private FilingTypeType filingTypeField;

        private AIFMContentTypeType aIFMContentTypeField;

        private DateTime reportingPeriodStartDateField;

        private DateTime reportingPeriodEndDateField;

        private ReportingPeriodTypeType reportingPeriodTypeField;

        private string reportingPeriodYearField;

        private ReportingObligationChangeFrequencyCodeType aIFMReportingObligationChangeFrequencyCodeField;

        private bool aIFMReportingObligationChangeFrequencyCodeFieldSpecified;

        private AIFMReportingObligationChangeContentsCodeType aIFMReportingObligationChangeContentsCodeField;

        private bool aIFMReportingObligationChangeContentsCodeFieldSpecified;

        private ReportingObligationChangeQuarterType aIFMReportingObligationChangeQuarterField;

        private bool aIFMReportingObligationChangeQuarterFieldSpecified;

        private bool lastReportingFlagField;

        private ComplexAssumptionType[] assumptionsField;

        private AIFMReportingCodeType aIFMReportingCodeField;

        private string aIFMJurisdictionField;

        private string aIFMNationalCodeField;

        private string aIFMNameField;

        private bool aIFMEEAFlagField;

        private bool aIFMNoReportingFlagField;

        private ComplexAIFMCompleteDescriptionType aIFMCompleteDescriptionField;

        public FilingTypeType FilingType
        {
            get
            {
                return this.filingTypeField;
            }
            set
            {
                this.filingTypeField = value;
            }
        }

        public AIFMContentTypeType AIFMContentType
        {
            get
            {
                return this.aIFMContentTypeField;
            }
            set
            {
                this.aIFMContentTypeField = value;
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodStartDate
        {
            get
            {
                return this.reportingPeriodStartDateField;
            }
            set
            {
                this.reportingPeriodStartDateField = value;
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime ReportingPeriodEndDate
        {
            get
            {
                return this.reportingPeriodEndDateField;
            }
            set
            {
                this.reportingPeriodEndDateField = value;
            }
        }

        public ReportingPeriodTypeType ReportingPeriodType
        {
            get
            {
                return this.reportingPeriodTypeField;
            }
            set
            {
                this.reportingPeriodTypeField = value;
            }
        }

        [XmlElement(DataType = "gYear")]
        public string ReportingPeriodYear
        {
            get
            {
                return this.reportingPeriodYearField;
            }
            set
            {
                this.reportingPeriodYearField = value;
            }
        }

        public ReportingObligationChangeFrequencyCodeType AIFMReportingObligationChangeFrequencyCode
        {
            get
            {
                return this.aIFMReportingObligationChangeFrequencyCodeField;
            }
            set
            {
                this.aIFMReportingObligationChangeFrequencyCodeField = value;
            }
        }

        [XmlIgnore]
        public bool AIFMReportingObligationChangeFrequencyCodeSpecified
        {
            get
            {
                return this.aIFMReportingObligationChangeFrequencyCodeFieldSpecified;
            }
            set
            {
                this.aIFMReportingObligationChangeFrequencyCodeFieldSpecified = value;
            }
        }

        public AIFMReportingObligationChangeContentsCodeType AIFMReportingObligationChangeContentsCode
        {
            get
            {
                return this.aIFMReportingObligationChangeContentsCodeField;
            }
            set
            {
                this.aIFMReportingObligationChangeContentsCodeField = value;
            }
        }

        [XmlIgnore]
        public bool AIFMReportingObligationChangeContentsCodeSpecified
        {
            get
            {
                return this.aIFMReportingObligationChangeContentsCodeFieldSpecified;
            }
            set
            {
                this.aIFMReportingObligationChangeContentsCodeFieldSpecified = value;
            }
        }

        public ReportingObligationChangeQuarterType AIFMReportingObligationChangeQuarter
        {
            get
            {
                return this.aIFMReportingObligationChangeQuarterField;
            }
            set
            {
                this.aIFMReportingObligationChangeQuarterField = value;
            }
        }

        [XmlIgnore]
        public bool AIFMReportingObligationChangeQuarterSpecified
        {
            get
            {
                return this.aIFMReportingObligationChangeQuarterFieldSpecified;
            }
            set
            {
                this.aIFMReportingObligationChangeQuarterFieldSpecified = value;
            }
        }

        public bool LastReportingFlag
        {
            get
            {
                return this.lastReportingFlagField;
            }
            set
            {
                this.lastReportingFlagField = value;
            }
        }

        [XmlArrayItem("Assumption", IsNullable = false)]
        public ComplexAssumptionType[] Assumptions
        {
            get
            {
                return this.assumptionsField;
            }
            set
            {
                this.assumptionsField = value;
            }
        }

        public AIFMReportingCodeType AIFMReportingCode
        {
            get
            {
                return this.aIFMReportingCodeField;
            }
            set
            {
                this.aIFMReportingCodeField = value;
            }
        }

        public string AIFMJurisdiction
        {
            get
            {
                return this.aIFMJurisdictionField;
            }
            set
            {
                this.aIFMJurisdictionField = value;
            }
        }

        public string AIFMNationalCode
        {
            get
            {
                return this.aIFMNationalCodeField;
            }
            set
            {
                this.aIFMNationalCodeField = value;
            }
        }

        public string AIFMName
        {
            get
            {
                return this.aIFMNameField;
            }
            set
            {
                this.aIFMNameField = value;
            }
        }

        public bool AIFMEEAFlag
        {
            get
            {
                return this.aIFMEEAFlagField;
            }
            set
            {
                this.aIFMEEAFlagField = value;
            }
        }

        public bool AIFMNoReportingFlag
        {
            get
            {
                return this.aIFMNoReportingFlagField;
            }
            set
            {
                this.aIFMNoReportingFlagField = value;
            }
        }

        public ComplexAIFMCompleteDescriptionType AIFMCompleteDescription
        {
            get
            {
                return this.aIFMCompleteDescriptionField;
            }
            set
            {
                this.aIFMCompleteDescriptionField = value;
            }
        }
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

        private string questionNumberField;

        private string assumptionDescriptionField;

        [XmlElement(DataType = "integer")]
        public string QuestionNumber
        {
            get
            {
                return this.questionNumberField;
            }
            set
            {
                this.questionNumberField = value;
            }
        }

        public string AssumptionDescription
        {
            get
            {
                return this.assumptionDescriptionField;
            }
            set
            {
                this.assumptionDescriptionField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexBaseCurrencyDescriptionType
    {

        private string baseCurrencyField;

        private string aUMAmountInBaseCurrencyField;

        private FXEURReferenceRateTypeType fXEURReferenceRateTypeField;

        private bool fXEURReferenceRateTypeFieldSpecified;

        private decimal fXEURRateField;

        private bool fXEURRateFieldSpecified;

        private string fXEUROtherReferenceRateDescriptionField;

        public string BaseCurrency
        {
            get
            {
                return this.baseCurrencyField;
            }
            set
            {
                this.baseCurrencyField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AUMAmountInBaseCurrency
        {
            get
            {
                return this.aUMAmountInBaseCurrencyField;
            }
            set
            {
                this.aUMAmountInBaseCurrencyField = value;
            }
        }

        public FXEURReferenceRateTypeType FXEURReferenceRateType
        {
            get
            {
                return this.fXEURReferenceRateTypeField;
            }
            set
            {
                this.fXEURReferenceRateTypeField = value;
            }
        }

        [XmlIgnore]
        public bool FXEURReferenceRateTypeSpecified
        {
            get
            {
                return this.fXEURReferenceRateTypeFieldSpecified;
            }
            set
            {
                this.fXEURReferenceRateTypeFieldSpecified = value;
            }
        }

        public decimal FXEURRate
        {
            get
            {
                return this.fXEURRateField;
            }
            set
            {
                this.fXEURRateField = value;
            }
        }

        [XmlIgnore]
        public bool FXEURRateSpecified
        {
            get
            {
                return this.fXEURRateFieldSpecified;
            }
            set
            {
                this.fXEURRateFieldSpecified = value;
            }
        }

        public string FXEUROtherReferenceRateDescription
        {
            get
            {
                return this.fXEUROtherReferenceRateDescriptionField;
            }
            set
            {
                this.fXEUROtherReferenceRateDescriptionField = value;
            }
        }
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

        private FiveRankingType rankingField;

        private SubAssetTypeType subAssetTypeField;

        private string aggregatedValueAmountField;

        public FiveRankingType Ranking
        {
            get
            {
                return this.rankingField;
            }
            set
            {
                this.rankingField = value;
            }
        }

        public SubAssetTypeType SubAssetType
        {
            get
            {
                return this.subAssetTypeField;
            }
            set
            {
                this.subAssetTypeField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount
        {
            get
            {
                return this.aggregatedValueAmountField;
            }
            set
            {
                this.aggregatedValueAmountField = value;
            }
        }
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

        private MarketCodeTypeWithNOTType marketCodeTypeField;

        private string marketCodeField;

        public MarketCodeTypeWithNOTType MarketCodeType
        {
            get
            {
                return this.marketCodeTypeField;
            }
            set
            {
                this.marketCodeTypeField = value;
            }
        }

        public string MarketCode
        {
            get
            {
                return this.marketCodeField;
            }
            set
            {
                this.marketCodeField = value;
            }
        }
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

        private FiveRankingType rankingField;

        private ComplexMarketIdentificationWithNOTType marketIdentificationField;

        private string aggregatedValueAmountField;

        public FiveRankingType Ranking
        {
            get
            {
                return this.rankingField;
            }
            set
            {
                this.rankingField = value;
            }
        }

        public ComplexMarketIdentificationWithNOTType MarketIdentification
        {
            get
            {
                return this.marketIdentificationField;
            }
            set
            {
                this.marketIdentificationField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount
        {
            get
            {
                return this.aggregatedValueAmountField;
            }
            set
            {
                this.aggregatedValueAmountField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFMNationalIdentifierType
    {

        private string reportingMemberStateField;

        private string aIFMNationalCodeField;

        public string ReportingMemberState
        {
            get
            {
                return this.reportingMemberStateField;
            }
            set
            {
                this.reportingMemberStateField = value;
            }
        }

        public string AIFMNationalCode
        {
            get
            {
                return this.aIFMNationalCodeField;
            }
            set
            {
                this.aIFMNationalCodeField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFMIdentifierType
    {

        private string aIFMIdentifierLEIField;

        private string aIFMIdentifierBICField;

        private ComplexAIFMNationalIdentifierType oldAIFMIdentifierNCAField;

        public string AIFMIdentifierLEI
        {
            get
            {
                return this.aIFMIdentifierLEIField;
            }
            set
            {
                this.aIFMIdentifierLEIField = value;
            }
        }

        public string AIFMIdentifierBIC
        {
            get
            {
                return this.aIFMIdentifierBICField;
            }
            set
            {
                this.aIFMIdentifierBICField = value;
            }
        }

        public ComplexAIFMNationalIdentifierType OldAIFMIdentifierNCA
        {
            get
            {
                return this.oldAIFMIdentifierNCAField;
            }
            set
            {
                this.oldAIFMIdentifierNCAField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFMCompleteDescriptionType
    {

        private ComplexAIFMIdentifierType aIFMIdentifierField;

        private ComplexFivePrincipalMarketType[] aIFMPrincipalMarketsField;

        private ComplexPrincipalInstrumentType[] aIFMPrincipalInstrumentsField;

        private string aUMAmountInEuroField;

        private ComplexBaseCurrencyDescriptionType aIFMBaseCurrencyDescriptionField;

        public ComplexAIFMIdentifierType AIFMIdentifier
        {
            get
            {
                return this.aIFMIdentifierField;
            }
            set
            {
                this.aIFMIdentifierField = value;
            }
        }

        [XmlArrayItem("AIFMFivePrincipalMarket", IsNullable = false)]
        public ComplexFivePrincipalMarketType[] AIFMPrincipalMarkets
        {
            get
            {
                return this.aIFMPrincipalMarketsField;
            }
            set
            {
                this.aIFMPrincipalMarketsField = value;
            }
        }

        [XmlArrayItem("AIFMPrincipalInstrument", IsNullable = false)]
        public ComplexPrincipalInstrumentType[] AIFMPrincipalInstruments
        {
            get
            {
                return this.aIFMPrincipalInstrumentsField;
            }
            set
            {
                this.aIFMPrincipalInstrumentsField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AUMAmountInEuro
        {
            get
            {
                return this.aUMAmountInEuroField;
            }
            set
            {
                this.aUMAmountInEuroField = value;
            }
        }

        public ComplexBaseCurrencyDescriptionType AIFMBaseCurrencyDescription
        {
            get
            {
                return this.aIFMBaseCurrencyDescriptionField;
            }
            set
            {
                this.aIFMBaseCurrencyDescriptionField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexCancellationAIFMRecordInfoType
    {

        private string cancelledAIFMNationalCodeField;

        private ReportingPeriodTypeType cancelledReportingPeriodTypeField;

        private string cancelledReportingPeriodYearField;

        private CancelledRecordFlagType cancelledRecordFlagField;

        public string CancelledAIFMNationalCode
        {
            get
            {
                return this.cancelledAIFMNationalCodeField;
            }
            set
            {
                this.cancelledAIFMNationalCodeField = value;
            }
        }

        public ReportingPeriodTypeType CancelledReportingPeriodType
        {
            get
            {
                return this.cancelledReportingPeriodTypeField;
            }
            set
            {
                this.cancelledReportingPeriodTypeField = value;
            }
        }

        [XmlElement(DataType = "gYear")]
        public string CancelledReportingPeriodYear
        {
            get
            {
                return this.cancelledReportingPeriodYearField;
            }
            set
            {
                this.cancelledReportingPeriodYearField = value;
            }
        }

        public CancelledRecordFlagType CancelledRecordFlag
        {
            get
            {
                return this.cancelledRecordFlagField;
            }
            set
            {
                this.cancelledRecordFlagField = value;
            }
        }
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
