namespace Schemas
{
    using System;
    using System.Xml.Serialization;

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
