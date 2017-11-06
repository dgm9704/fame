namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public partial class ComplexRiskProfileType
    {

        public ComplexMarketRiskProfileType MarketRiskProfile {get; set;}

        public ComplexCounterpartyRiskProfile CounterpartyRiskProfile {get; set;}

        public ComplexLiquidityRiskProfileType LiquidityRiskProfile {get; set;}

        public ComplexOperationalRiskType OperationalRisk {get; set;}
    }

    [Serializable]
    public partial class ComplexCompanyDominantInfluenceType
    {

        public ComplexEntityIdentificationType CompanyIdentification {get; set;}

        public TransactionType TransactionType {get; set;}

        public string OtherTransactionTypeDescription {get; set;}

        public decimal VotingRightsRate {get; set;}
    }

    [Serializable]
    public enum TransactionType
    {

        ACAP,

        BOUT,

        CONS,

        CDIV,

        ESOP,

        GCAP,

        RCAP,

        SLIQ,

        TURN,

        OTHR,
    }

    [Serializable]
    public partial class ComplexCurrencyExposureType
    {

        public string ExposureCurrency {get; set;}

        [XmlElement(DataType = "integer")]
        public string LongPositionValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string ShortPositionValue {get; set;}
    }

    [Serializable]
    public partial class ComplexAssetTypeTurnoverType
    {

        public TurnoverSubAssetType TurnoverSubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string MarketValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string NotionalValue {get; set;}
    }

    [Serializable]
    public enum TurnoverSubAssetType
    {

        SEC_CSH_CSH,

        SEC_LEQ_LEQ,

        SEC_UEQ_UEQ,

        SEC_CPN_IVG,

        SEC_CPN_NIG,

        SEC_CPI_CPI,

        SEC_SBD_EUB,

        SEC_SBD_NEU,

        SEC_MUN_MUN,

        SEC_CBD_CBD,

        SEC_LON_LON,

        SEC_SSP_SSP,

        DER_EQD_EQD,

        DER_FID_FID,

        DER_CDS_CDS,

        DER_FEX_INV,

        DER_FEX_HED,

        DER_IRD_IRD,

        DER_CTY_CTY,

        DER_OTH_OTH,

        PHY_RES_RES,

        PHY_CTY_CTY,

        PHY_TIM_TIM,

        PHY_ART_ART,

        PHY_TPT_TPT,

        PHY_OTH_OTH,

        CIU_CIU_CIU,

        OTH_OTH_OTH,
    }

    [Serializable]
    public partial class ComplexAssetTypeExposureType
    {

        public SubAssetType SubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string GrossValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string LongValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string ShortValue {get; set;}
    }

    [Serializable]
    public partial class ComplexIndividualExposureType
    {

        [XmlArrayItem("AssetTypeExposure", IsNullable = false)]
        public ComplexAssetTypeExposureType[] AssetTypeExposures {get; set;}

        [XmlArrayItem("AssetTypeTurnover", IsNullable = false)]
        public ComplexAssetTypeTurnoverType[] AssetTypeTurnovers {get; set;}

        [XmlArrayItem("CurrencyExposure", IsNullable = false)]
        public ComplexCurrencyExposureType[] CurrencyExposures {get; set;}

        [XmlArrayItem("CompanyDominantInfluence", IsNullable = false)]
        public ComplexCompanyDominantInfluenceType[] CompaniesDominantInfluence {get; set;}
    }

    [Serializable]
    public partial class ComplexAIFIndividualInfoType
    {

        public ComplexIndividualExposureType IndividualExposure {get; set;}

        public ComplexRiskProfileType RiskProfile {get; set;}

        public ComplexStressTests StressTests {get; set;}
    }

    [Serializable]
    public partial class ComplexInvestorConcentrationType
    {

        public decimal MainBeneficialOwnersRate {get; set;}

        public decimal ProfessionalInvestorConcentrationRate {get; set;}

        public decimal RetailInvestorConcentrationRate {get; set;}
    }

    [Serializable]
    public partial class ComplexThreePrincipalMarketType
    {

        public ThreeRankingType Ranking {get; set;}

        public ComplexMarketIdentificationWithNOTType MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }

    [Serializable]
    public partial class ComplexMarketIdentificationWithoutNOTType
    {

        public MarketCodeTypeWithoutNOTType MarketCodeType {get; set;}

        public string MarketCode {get; set;}
    }

    [Serializable]
    public enum MarketCodeTypeWithoutNOTType
    {

        MIC,

        OTC,

        XXX,
    }

    [Serializable]
    public partial class ComplexPortfolioConcentrationType
    {

        public FiveRanking Ranking {get; set;}

        public AssetType AssetType {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        public ComplexMarketIdentificationWithoutNOTType MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}

        public decimal AggregatedValueRate {get; set;}

        [XmlIgnore]
        public bool AggregatedValueRateSpecified {get; set;}

        public ComplexEntityIdentificationType CounterpartyIdentification {get; set;}
    }

    [Serializable]
    public enum AssetType
    {

        SEC_CSH,

        SEC_LEQ,

        SEC_UEQ,

        SEC_CPN,

        SEC_CPI,

        SEC_SBD,

        SEC_MBN,

        SEC_CBN,

        SEC_CBI,

        SEC_LON,

        SEC_SSP,

        DER_EQD,

        DER_FID,

        DER_CDS,

        DER_FEX,

        DER_IRD,

        DER_CTY,

        DER_OTH,

        PHY_RES,

        PHY_CTY,

        PHY_TIM,

        PHY_ART,

        PHY_TPT,

        PHY_OTH,

        CIU_OAM,

        CIU_NAM,

        OTH_OTH,

        NTA_NTA,
    }

    [Serializable]
    public enum PositionType
    {

        L,

        S,
    }

    [Serializable]
    public partial class ComplexMostImportantConcentrationType
    {

        [XmlArrayItem("PortfolioConcentration", IsNullable = false)]
        public ComplexPortfolioConcentrationType[] PortfolioConcentrations {get; set;}

        public TypicalPositionSizeType TypicalPositionSize {get; set;}

        [XmlIgnore]
        public bool TypicalPositionSizeSpecified {get; set;}

        [XmlArrayItem("AIFPrincipalMarket", IsNullable = false)]
        public ComplexThreePrincipalMarketType[] AIFPrincipalMarkets {get; set;}

        public ComplexInvestorConcentrationType InvestorConcentration {get; set;}
    }

    [Serializable]
    public enum TypicalPositionSizeType
    {

        V_SMALL,

        SMALL,

        LOW_MID_MKT,

        UP_MID_MKT,

        L_CAP,

        M_CAP,
    }

    [Serializable]
    public partial class ComplexPrincipalExposureType
    {

        public TenRankingType Ranking {get; set;}

        public AssetMacroType AssetMacroType {get; set;}

        public SubAssetType SubAssetType {get; set;}

        [XmlIgnore]
        public bool SubAssetTypeSpecified {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}

        public decimal AggregatedValueRate {get; set;}

        [XmlIgnore]
        public bool AggregatedValueRateSpecified {get; set;}

        public ComplexEntityIdentificationType CounterpartyIdentification {get; set;}
    }

    [Serializable]
    public enum TenRankingType
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

        [XmlEnum("10")]
        Item10,
    }

    [Serializable]
    public enum AssetMacroType
    {

        SEC,

        DER,

        CIU,

        PHY,

        OTH,

        NTA,
    }

    [Serializable]
    public partial class ComplexAUMGeographicalFocusType
    {

        public decimal AfricaAUMRate {get; set;}

        public decimal AsiaPacificAUMRate {get; set;}

        public decimal EuropeAUMRate {get; set;}

        public decimal EEAAUMRate {get; set;}

        public decimal MiddleEastAUMRate {get; set;}

        public decimal NorthAmericaAUMRate {get; set;}

        public decimal SouthAmericaAUMRate {get; set;}

        public decimal SupraNationalAUMRate {get; set;}
    }

    [Serializable]
    public partial class ComplexNAVGeographicalFocusType
    {

        public decimal AfricaNAVRate {get; set;}

        public decimal AsiaPacificNAVRate {get; set;}

        public decimal EuropeNAVRate {get; set;}

        public decimal EEANAVRate {get; set;}

        public decimal MiddleEastNAVRate {get; set;}

        public decimal NorthAmericaNAVRate {get; set;}

        public decimal SouthAmericaNAVRate {get; set;}

        public decimal SupraNationalNAVRate {get; set;}
    }

    [Serializable]
    public partial class ComplexAIIInstrumentIdentificationType
    {

        public string AIIExchangeCode {get; set;}

        public string AIIProductCode {get; set;}

        public AIIDerivativeType AIIDerivativeType {get; set;}

        public AIIPutCallIdentifierType AIIPutCallIdentifier {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime AIIExpiryDate {get; set;}

        public decimal AIIStrikePrice {get; set;}
    }

    [Serializable]
    public partial class ComplexMainInstrumentTradedType
    {

        public FiveRanking Ranking {get; set;}

        public SubAssetType SubAssetType {get; set;}

        public InstrumentCodeType InstrumentCodeType {get; set;}

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified {get; set;}

        public string InstrumentName {get; set;}

        [XmlElement("AIIInstrumentIdentification", typeof(ComplexAIIInstrumentIdentificationType))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item {get; set;}

        [XmlElement(DataType = "integer")]
        public string PositionValue {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        public decimal ShortPositionHedgingRate {get; set;}

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexOtherFundStrategyType
    {

        public OtherFundStrategyType OtherFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public enum OtherFundStrategyType
    {

        OTHR_COMF,

        OTHR_EQYF,

        OTHR_FXIF,

        OTHR_INFF,

        OTHR_OTHF,
    }

    [Serializable]
    public partial class ComplexFundOfFundsStrategyType
    {

        public FundOfFundsStrategyType FundOfFundsStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public partial class ComplexRealEstateFundStrategyType
    {

        public RealEstateFundStrategyType RealEstateFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }
}
