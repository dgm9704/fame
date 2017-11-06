namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public partial class ComplexHistoricalRiskProfileType
    {






        public ComplexSignedRateMonthPeriodType GrossInvestmentReturnsRate {get; set;}

        public ComplexSignedRateMonthPeriodType NetInvestmentReturnsRate {get; set;}

        public ComplexSignedRateMonthPeriodType NAVChangeRate {get; set;}

        public ComplexQuantityMonthPeriodType Subscription {get; set;}

        public ComplexQuantityMonthPeriodType Redemption {get; set;}
    }

    [Serializable]
    public partial class ComplexOperationalRiskType
    {



        [XmlElement(DataType = "integer")]
        public string TotalOpenPositions {get; set;}

        public ComplexHistoricalRiskProfileType HistoricalRiskProfile {get; set;}
    }

    [Serializable]
    public partial class ComplexFinancingLiquidityProfileType
    {









        [XmlElement(DataType = "integer")]
        public string TotalFinancingAmount {get; set;}

        public decimal TotalFinancingInDays0to1Rate {get; set;}

        public decimal TotalFinancingInDays2to7Rate {get; set;}

        public decimal TotalFinancingInDays8to30Rate {get; set;}

        public decimal TotalFinancingInDays31to90Rate {get; set;}

        public decimal TotalFinancingInDays91to180Rate {get; set;}

        public decimal TotalFinancingInDays181to365Rate {get; set;}

        public decimal TotalFinancingInDays365MoreRate {get; set;}
    }

    [Serializable]
    public partial class ComplexInvestorGroupType
    {



        public InvestorGroupTypeType InvestorGroupType {get; set;}

        public decimal InvestorGroupRate {get; set;}
    }

    [Serializable]
    public enum InvestorGroupTypeType
    {

        NFCO,

        BANK,

        INSC,

        OFIN,

        PFND,

        GENG,

        OCIU,

        HHLD,

        UNKN,

        NONE,
    }

    [Serializable]
    public partial class ComplexInvestorPreferentialTreatmentType
    {










        public bool InvestorPreferentialTreatmentFlag {get; set;}

        public bool DisclosureTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool DisclosureTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool LiquidityTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool LiquidityTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool FeeTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool FeeTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool OtherTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool OtherTermsPreferentialTreatmentFlagSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexOtherArrangementType
    {



        public string OtherArrangementType {get; set;}

        public decimal OtherArrangementRate {get; set;}
    }

    [Serializable]
    public partial class ComplexInvestorIlliquidAssetArrangementType
    {










        public decimal SidePocketRate {get; set;}

        [XmlIgnore]
        public bool SidePocketRateSpecified {get; set;}

        public decimal GatesRate {get; set;}

        [XmlIgnore]
        public bool GatesRateSpecified {get; set;}

        public decimal DealingSuspensionRate {get; set;}

        [XmlIgnore]
        public bool DealingSuspensionRateSpecified {get; set;}

        public ComplexOtherArrangementType OtherArrangement {get; set;}

        public decimal TotalArrangementRate {get; set;}

        [XmlIgnore]
        public bool TotalArrangementRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexInvestorArrangementType
    {



        public ComplexInvestorIlliquidAssetArrangementType InvestorIlliquidAssetArrangement {get; set;}

        public ComplexInvestorPreferentialTreatmentType InvestorPreferentialTreatment {get; set;}
    }

    [Serializable]
    public partial class ComplexInvestorRedemptionType
    {






        public bool ProvideWithdrawalRightsFlag {get; set;}

        public InvestorRedemptionFrequencyType InvestorRedemptionFrequency {get; set;}

        [XmlIgnore]
        public bool InvestorRedemptionFrequencySpecified {get; set;}

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionNoticePeriod {get; set;}

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionLockUpPeriod {get; set;}
    }

    [Serializable]
    public enum InvestorRedemptionFrequencyType
    {

        D,

        W,

        F,

        M,

        Q,

        H,

        Y,

        O,

        N,
    }

    [Serializable]
    public partial class ComplexInvestorLiquidityProfileType
    {








        public decimal InvestorLiquidityInDays0to1Rate {get; set;}

        public decimal InvestorLiquidityInDays2to7Rate {get; set;}

        public decimal InvestorLiquidityInDays8to30Rate {get; set;}

        public decimal InvestorLiquidityInDays31to90Rate {get; set;}

        public decimal InvestorLiquidityInDays91to180Rate {get; set;}

        public decimal InvestorLiquidityInDays181to365Rate {get; set;}

        public decimal InvestorLiquidityInDays365MoreRate {get; set;}
    }

    [Serializable]
    public partial class ComplexPortfolioLiquidityProfileType
    {









        public decimal PortfolioLiquidityInDays0to1Rate {get; set;}

        public decimal PortfolioLiquidityInDays2to7Rate {get; set;}

        public decimal PortfolioLiquidityInDays8to30Rate {get; set;}

        public decimal PortfolioLiquidityInDays31to90Rate {get; set;}

        public decimal PortfolioLiquidityInDays91to180Rate {get; set;}

        public decimal PortfolioLiquidityInDays181to365Rate {get; set;}

        public decimal PortfolioLiquidityInDays365MoreRate {get; set;}

        [XmlElement(DataType = "integer")]
        public string UnencumberedCash {get; set;}
    }

    [Serializable]
    public partial class ComplexLiquidityRiskProfileType
    {







        public ComplexPortfolioLiquidityProfileType PortfolioLiquidityProfile {get; set;}

        public ComplexInvestorLiquidityProfileType InvestorLiquidityProfile {get; set;}

        public ComplexInvestorRedemptionType InvestorRedemption {get; set;}

        public ComplexInvestorArrangementType InvestorArrangement {get; set;}

        [XmlArrayItem("InvestorGroup", IsNullable = false)]
        public ComplexInvestorGroupType[] InvestorGroups {get; set;}

        public ComplexFinancingLiquidityProfileType FinancingLiquidityProfile {get; set;}
    }

    [Serializable]
    public partial class ComplexCCPExposureType
    {




        public ThreeRankingType Ranking {get; set;}

        public ComplexEntityIdentificationType CCPIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string CCPExposureValue {get; set;}
    }

    [Serializable]
    public enum ThreeRankingType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,
    }

    [Serializable]
    public partial class ComplexCounterpartyExposureType
    {






        public FiveRankingType Ranking {get; set;}

        public bool CounterpartyExposureFlag {get; set;}

        public ComplexEntityIdentificationType CounterpartyIdentification {get; set;}

        public decimal CounterpartyTotalExposureRate {get; set;}

        [XmlIgnore]
        public bool CounterpartyTotalExposureRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexAllCounterpartyCollateralType
    {




        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralCash {get; set;}

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralSecurities {get; set;}

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyOtherCollateralPosted {get; set;}
    }

    [Serializable]
    public partial class ComplexClearedReposRateType
    {







        public decimal CCPRate {get; set;}

        [XmlIgnore]
        public bool CCPRateSpecified {get; set;}

        public decimal BilateralClearingRate {get; set;}

        [XmlIgnore]
        public bool BilateralClearingRateSpecified {get; set;}

        public decimal TriPartyRepoClearingRate {get; set;}

        [XmlIgnore]
        public bool TriPartyRepoClearingRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexClearedDerivativesRateType
    {





        public decimal CCPRate {get; set;}

        [XmlIgnore]
        public bool CCPRateSpecified {get; set;}

        public decimal BilateralClearingRate {get; set;}

        [XmlIgnore]
        public bool BilateralClearingRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexMarketRate3p2Type
    {





        public decimal RegulatedMarketRate {get; set;}

        [XmlIgnore]
        public bool RegulatedMarketRateSpecified {get; set;}

        public decimal OTCRate {get; set;}

        [XmlIgnore]
        public bool OTCRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexTradingClearingMechanismType
    {





        public ComplexMarketRate3p2Type TradedSecurities {get; set;}

        public ComplexMarketRate3p2Type TradedDerivatives {get; set;}

        public ComplexClearedDerivativesRateType ClearedDerivativesRate {get; set;}

        public ComplexClearedReposRateType ClearedReposRate {get; set;}
    }

    [Serializable]
    public partial class ComplexCounterpartyRiskProfileType
    {







        public ComplexTradingClearingMechanismType TradingClearingMechanism {get; set;}

        public ComplexAllCounterpartyCollateralType AllCounterpartyCollateral {get; set;}

        [XmlArrayItem("FundToCounterpartyExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] FundToCounterpartyExposures {get; set;}

        [XmlArrayItem("CounterpartyToFundExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] CounterpartyToFundExposures {get; set;}

        public bool ClearTransactionsThroughCCPFlag {get; set;}

        [XmlArrayItem("CCPExposure", IsNullable = false)]
        public ComplexCCPExposureType[] CCPExposures {get; set;}
    }

    [Serializable]
    public partial class ComplexVARRiskMeasureValuesType
    {





        public decimal VARValue {get; set;}

        [XmlIgnore]
        public bool VARValueSpecified {get; set;}

        public VARCalculationMethodCodeTypeType VARCalculationMethodCodeType {get; set;}

        [XmlIgnore]
        public bool VARCalculationMethodCodeTypeSpecified {get; set;}
    }

    [Serializable]
    public enum VARCalculationMethodCodeTypeType
    {

        HISTO,

        CARLO,

        PARAM,
    }

    [Serializable]
    public partial class ComplexVegaRiskMeasureValuesType
    {







        public decimal CurrentMarketRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool CurrentMarketRiskMeasureValueSpecified {get; set;}

        public decimal LowerMarketRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool LowerMarketRiskMeasureValueSpecified {get; set;}

        public decimal HigherMarketRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool HigherMarketRiskMeasureValueSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexBucketRiskMeasureValuesType
    {







        public decimal LessFiveYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool LessFiveYearsRiskMeasureValueSpecified {get; set;}

        public decimal FifthteenYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool FifthteenYearsRiskMeasureValueSpecified {get; set;}

        public decimal MoreFifthteenYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool MoreFifthteenYearsRiskMeasureValueSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexMarketRiskMeasureType
    {




        public RiskMeasureTypeType RiskMeasureType {get; set;}

        [XmlElement("BucketRiskMeasureValues", typeof(ComplexBucketRiskMeasureValuesType))]
        [XmlElement("RiskMeasureValue", typeof(decimal))]
        [XmlElement("VARRiskMeasureValues", typeof(ComplexVARRiskMeasureValuesType))]
        [XmlElement("VegaRiskMeasureValues", typeof(ComplexVegaRiskMeasureValuesType))]
        public object Item {get; set;}

        public string RiskMeasureDescription {get; set;}
    }

    [Serializable]
    public enum RiskMeasureTypeType
    {

        NET_EQTY_DELTA,

        NET_DV01,

        NET_CS01,

        VAR,

        VEGA_EXPO,

        NET_FX_DELTA,

        NET_CTY_DELTA,
    }

    [Serializable]
    public partial class ComplexMarketRiskProfileType
    {



        public string AnnualInvestmentReturnRate {get; set;}

        [XmlArrayItem("MarketRiskMeasure", IsNullable = false)]
        public ComplexMarketRiskMeasureType[] MarketRiskMeasures {get; set;}
    }

    [Serializable]
    public partial class ComplexRiskProfileType
    {





        public ComplexMarketRiskProfileType MarketRiskProfile {get; set;}

        public ComplexCounterpartyRiskProfileType CounterpartyRiskProfile {get; set;}

        public ComplexLiquidityRiskProfileType LiquidityRiskProfile {get; set;}

        public ComplexOperationalRiskType OperationalRisk {get; set;}
    }

    [Serializable]
    public partial class ComplexCompanyDominantInfluenceType
    {





        public ComplexEntityIdentificationType CompanyIdentification {get; set;}

        public TransactionTypeType TransactionType {get; set;}

        public string OtherTransactionTypeDescription {get; set;}

        public decimal VotingRightsRate {get; set;}
    }

    [Serializable]
    public enum TransactionTypeType
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




        public TurnoverSubAssetTypeType TurnoverSubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string MarketValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string NotionalValue {get; set;}
    }

    [Serializable]
    public enum TurnoverSubAssetTypeType
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





        public SubAssetTypeType SubAssetType {get; set;}

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

        public ComplexStressTestsType StressTests {get; set;}
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










        public FiveRankingType Ranking {get; set;}

        public AssetTypeType AssetType {get; set;}

        public PositionTypeType PositionType {get; set;}

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
    public enum AssetTypeType
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
    public enum PositionTypeType
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

        public AssetMacroTypeType AssetMacroType {get; set;}

        public SubAssetTypeType SubAssetType {get; set;}

        [XmlIgnore]
        public bool SubAssetTypeSpecified {get; set;}

        public PositionTypeType PositionType {get; set;}

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
    public enum AssetMacroTypeType
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

        public AIIDerivativeTypeType AIIDerivativeType {get; set;}

        public AIIPutCallIdentifierType AIIPutCallIdentifier {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime AIIExpiryDate {get; set;}

        public decimal AIIStrikePrice {get; set;}
    }

    [Serializable]
    public partial class ComplexMainInstrumentTradedType
    {












        public FiveRankingType Ranking {get; set;}

        public SubAssetTypeType SubAssetType {get; set;}

        public InstrumentCodeTypeType InstrumentCodeType {get; set;}

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified {get; set;}

        public string InstrumentName {get; set;}

        [XmlElement("AIIInstrumentIdentification", typeof(ComplexAIIInstrumentIdentificationType))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item {get; set;}

        [XmlElement(DataType = "integer")]
        public string PositionValue {get; set;}

        public PositionTypeType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        public decimal ShortPositionHedgingRate {get; set;}

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified {get; set;}
    }

    [Serializable]
    public partial class ComplexOtherFundStrategyType
    {






        public OtherFundStrategyTypeType OtherFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public enum OtherFundStrategyTypeType
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






        public FundOfFundsStrategyTypeType FundOfFundsStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public partial class ComplexRealEstateFundStrategyType
    {






        public RealEstateFundStrategyTypeType RealEstateFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }
}
