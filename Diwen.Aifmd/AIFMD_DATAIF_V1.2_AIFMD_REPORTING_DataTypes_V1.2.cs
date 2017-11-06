namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public partial class ComplexHistoricalRiskProfileType
    {

        private ComplexSignedRateMonthPeriodType grossInvestmentReturnsRateField;

        private ComplexSignedRateMonthPeriodType netInvestmentReturnsRateField;

        private ComplexSignedRateMonthPeriodType nAVChangeRateField;

        private ComplexQuantityMonthPeriodType subscriptionField;

        private ComplexQuantityMonthPeriodType redemptionField;

        public ComplexSignedRateMonthPeriodType GrossInvestmentReturnsRate
        {
            get
            {
                return this.grossInvestmentReturnsRateField;
            }
            set
            {
                this.grossInvestmentReturnsRateField = value;
            }
        }

        public ComplexSignedRateMonthPeriodType NetInvestmentReturnsRate
        {
            get
            {
                return this.netInvestmentReturnsRateField;
            }
            set
            {
                this.netInvestmentReturnsRateField = value;
            }
        }

        public ComplexSignedRateMonthPeriodType NAVChangeRate
        {
            get
            {
                return this.nAVChangeRateField;
            }
            set
            {
                this.nAVChangeRateField = value;
            }
        }

        public ComplexQuantityMonthPeriodType Subscription
        {
            get
            {
                return this.subscriptionField;
            }
            set
            {
                this.subscriptionField = value;
            }
        }

        public ComplexQuantityMonthPeriodType Redemption
        {
            get
            {
                return this.redemptionField;
            }
            set
            {
                this.redemptionField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexOperationalRiskType
    {

        private string totalOpenPositionsField;

        private ComplexHistoricalRiskProfileType historicalRiskProfileField;

        [XmlElement(DataType = "integer")]
        public string TotalOpenPositions
        {
            get
            {
                return this.totalOpenPositionsField;
            }
            set
            {
                this.totalOpenPositionsField = value;
            }
        }

        public ComplexHistoricalRiskProfileType HistoricalRiskProfile
        {
            get
            {
                return this.historicalRiskProfileField;
            }
            set
            {
                this.historicalRiskProfileField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexFinancingLiquidityProfileType
    {

        private string totalFinancingAmountField;

        private decimal totalFinancingInDays0to1RateField;

        private decimal totalFinancingInDays2to7RateField;

        private decimal totalFinancingInDays8to30RateField;

        private decimal totalFinancingInDays31to90RateField;

        private decimal totalFinancingInDays91to180RateField;

        private decimal totalFinancingInDays181to365RateField;

        private decimal totalFinancingInDays365MoreRateField;

        [XmlElement(DataType = "integer")]
        public string TotalFinancingAmount
        {
            get
            {
                return this.totalFinancingAmountField;
            }
            set
            {
                this.totalFinancingAmountField = value;
            }
        }

        public decimal TotalFinancingInDays0to1Rate
        {
            get
            {
                return this.totalFinancingInDays0to1RateField;
            }
            set
            {
                this.totalFinancingInDays0to1RateField = value;
            }
        }

        public decimal TotalFinancingInDays2to7Rate
        {
            get
            {
                return this.totalFinancingInDays2to7RateField;
            }
            set
            {
                this.totalFinancingInDays2to7RateField = value;
            }
        }

        public decimal TotalFinancingInDays8to30Rate
        {
            get
            {
                return this.totalFinancingInDays8to30RateField;
            }
            set
            {
                this.totalFinancingInDays8to30RateField = value;
            }
        }

        public decimal TotalFinancingInDays31to90Rate
        {
            get
            {
                return this.totalFinancingInDays31to90RateField;
            }
            set
            {
                this.totalFinancingInDays31to90RateField = value;
            }
        }

        public decimal TotalFinancingInDays91to180Rate
        {
            get
            {
                return this.totalFinancingInDays91to180RateField;
            }
            set
            {
                this.totalFinancingInDays91to180RateField = value;
            }
        }

        public decimal TotalFinancingInDays181to365Rate
        {
            get
            {
                return this.totalFinancingInDays181to365RateField;
            }
            set
            {
                this.totalFinancingInDays181to365RateField = value;
            }
        }

        public decimal TotalFinancingInDays365MoreRate
        {
            get
            {
                return this.totalFinancingInDays365MoreRateField;
            }
            set
            {
                this.totalFinancingInDays365MoreRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexInvestorGroupType
    {

        private InvestorGroupTypeType investorGroupTypeField;

        private decimal investorGroupRateField;

        public InvestorGroupTypeType InvestorGroupType
        {
            get
            {
                return this.investorGroupTypeField;
            }
            set
            {
                this.investorGroupTypeField = value;
            }
        }

        public decimal InvestorGroupRate
        {
            get
            {
                return this.investorGroupRateField;
            }
            set
            {
                this.investorGroupRateField = value;
            }
        }
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

        private bool investorPreferentialTreatmentFlagField;

        private bool disclosureTermsPreferentialTreatmentFlagField;

        private bool disclosureTermsPreferentialTreatmentFlagFieldSpecified;

        private bool liquidityTermsPreferentialTreatmentFlagField;

        private bool liquidityTermsPreferentialTreatmentFlagFieldSpecified;

        private bool feeTermsPreferentialTreatmentFlagField;

        private bool feeTermsPreferentialTreatmentFlagFieldSpecified;

        private bool otherTermsPreferentialTreatmentFlagField;

        private bool otherTermsPreferentialTreatmentFlagFieldSpecified;

        public bool InvestorPreferentialTreatmentFlag
        {
            get
            {
                return this.investorPreferentialTreatmentFlagField;
            }
            set
            {
                this.investorPreferentialTreatmentFlagField = value;
            }
        }

        public bool DisclosureTermsPreferentialTreatmentFlag
        {
            get
            {
                return this.disclosureTermsPreferentialTreatmentFlagField;
            }
            set
            {
                this.disclosureTermsPreferentialTreatmentFlagField = value;
            }
        }

        [XmlIgnore]
        public bool DisclosureTermsPreferentialTreatmentFlagSpecified
        {
            get
            {
                return this.disclosureTermsPreferentialTreatmentFlagFieldSpecified;
            }
            set
            {
                this.disclosureTermsPreferentialTreatmentFlagFieldSpecified = value;
            }
        }

        public bool LiquidityTermsPreferentialTreatmentFlag
        {
            get
            {
                return this.liquidityTermsPreferentialTreatmentFlagField;
            }
            set
            {
                this.liquidityTermsPreferentialTreatmentFlagField = value;
            }
        }

        [XmlIgnore]
        public bool LiquidityTermsPreferentialTreatmentFlagSpecified
        {
            get
            {
                return this.liquidityTermsPreferentialTreatmentFlagFieldSpecified;
            }
            set
            {
                this.liquidityTermsPreferentialTreatmentFlagFieldSpecified = value;
            }
        }

        public bool FeeTermsPreferentialTreatmentFlag
        {
            get
            {
                return this.feeTermsPreferentialTreatmentFlagField;
            }
            set
            {
                this.feeTermsPreferentialTreatmentFlagField = value;
            }
        }

        [XmlIgnore]
        public bool FeeTermsPreferentialTreatmentFlagSpecified
        {
            get
            {
                return this.feeTermsPreferentialTreatmentFlagFieldSpecified;
            }
            set
            {
                this.feeTermsPreferentialTreatmentFlagFieldSpecified = value;
            }
        }

        public bool OtherTermsPreferentialTreatmentFlag
        {
            get
            {
                return this.otherTermsPreferentialTreatmentFlagField;
            }
            set
            {
                this.otherTermsPreferentialTreatmentFlagField = value;
            }
        }

        [XmlIgnore]
        public bool OtherTermsPreferentialTreatmentFlagSpecified
        {
            get
            {
                return this.otherTermsPreferentialTreatmentFlagFieldSpecified;
            }
            set
            {
                this.otherTermsPreferentialTreatmentFlagFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexOtherArrangementType
    {

        private string otherArrangementTypeField;

        private decimal otherArrangementRateField;

        public string OtherArrangementType
        {
            get
            {
                return this.otherArrangementTypeField;
            }
            set
            {
                this.otherArrangementTypeField = value;
            }
        }

        public decimal OtherArrangementRate
        {
            get
            {
                return this.otherArrangementRateField;
            }
            set
            {
                this.otherArrangementRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexInvestorIlliquidAssetArrangementType
    {

        private decimal sidePocketRateField;

        private bool sidePocketRateFieldSpecified;

        private decimal gatesRateField;

        private bool gatesRateFieldSpecified;

        private decimal dealingSuspensionRateField;

        private bool dealingSuspensionRateFieldSpecified;

        private ComplexOtherArrangementType otherArrangementField;

        private decimal totalArrangementRateField;

        private bool totalArrangementRateFieldSpecified;

        public decimal SidePocketRate
        {
            get
            {
                return this.sidePocketRateField;
            }
            set
            {
                this.sidePocketRateField = value;
            }
        }

        [XmlIgnore]
        public bool SidePocketRateSpecified
        {
            get
            {
                return this.sidePocketRateFieldSpecified;
            }
            set
            {
                this.sidePocketRateFieldSpecified = value;
            }
        }

        public decimal GatesRate
        {
            get
            {
                return this.gatesRateField;
            }
            set
            {
                this.gatesRateField = value;
            }
        }

        [XmlIgnore]
        public bool GatesRateSpecified
        {
            get
            {
                return this.gatesRateFieldSpecified;
            }
            set
            {
                this.gatesRateFieldSpecified = value;
            }
        }

        public decimal DealingSuspensionRate
        {
            get
            {
                return this.dealingSuspensionRateField;
            }
            set
            {
                this.dealingSuspensionRateField = value;
            }
        }

        [XmlIgnore]
        public bool DealingSuspensionRateSpecified
        {
            get
            {
                return this.dealingSuspensionRateFieldSpecified;
            }
            set
            {
                this.dealingSuspensionRateFieldSpecified = value;
            }
        }

        public ComplexOtherArrangementType OtherArrangement
        {
            get
            {
                return this.otherArrangementField;
            }
            set
            {
                this.otherArrangementField = value;
            }
        }

        public decimal TotalArrangementRate
        {
            get
            {
                return this.totalArrangementRateField;
            }
            set
            {
                this.totalArrangementRateField = value;
            }
        }

        [XmlIgnore]
        public bool TotalArrangementRateSpecified
        {
            get
            {
                return this.totalArrangementRateFieldSpecified;
            }
            set
            {
                this.totalArrangementRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexInvestorArrangementType
    {

        private ComplexInvestorIlliquidAssetArrangementType investorIlliquidAssetArrangementField;

        private ComplexInvestorPreferentialTreatmentType investorPreferentialTreatmentField;

        public ComplexInvestorIlliquidAssetArrangementType InvestorIlliquidAssetArrangement
        {
            get
            {
                return this.investorIlliquidAssetArrangementField;
            }
            set
            {
                this.investorIlliquidAssetArrangementField = value;
            }
        }

        public ComplexInvestorPreferentialTreatmentType InvestorPreferentialTreatment
        {
            get
            {
                return this.investorPreferentialTreatmentField;
            }
            set
            {
                this.investorPreferentialTreatmentField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexInvestorRedemptionType
    {

        private bool provideWithdrawalRightsFlagField;

        private InvestorRedemptionFrequencyType investorRedemptionFrequencyField;

        private bool investorRedemptionFrequencyFieldSpecified;

        private string investorRedemptionNoticePeriodField;

        private string investorRedemptionLockUpPeriodField;

        public bool ProvideWithdrawalRightsFlag
        {
            get
            {
                return this.provideWithdrawalRightsFlagField;
            }
            set
            {
                this.provideWithdrawalRightsFlagField = value;
            }
        }

        public InvestorRedemptionFrequencyType InvestorRedemptionFrequency
        {
            get
            {
                return this.investorRedemptionFrequencyField;
            }
            set
            {
                this.investorRedemptionFrequencyField = value;
            }
        }

        [XmlIgnore]
        public bool InvestorRedemptionFrequencySpecified
        {
            get
            {
                return this.investorRedemptionFrequencyFieldSpecified;
            }
            set
            {
                this.investorRedemptionFrequencyFieldSpecified = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionNoticePeriod
        {
            get
            {
                return this.investorRedemptionNoticePeriodField;
            }
            set
            {
                this.investorRedemptionNoticePeriodField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionLockUpPeriod
        {
            get
            {
                return this.investorRedemptionLockUpPeriodField;
            }
            set
            {
                this.investorRedemptionLockUpPeriodField = value;
            }
        }
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

        private decimal investorLiquidityInDays0to1RateField;

        private decimal investorLiquidityInDays2to7RateField;

        private decimal investorLiquidityInDays8to30RateField;

        private decimal investorLiquidityInDays31to90RateField;

        private decimal investorLiquidityInDays91to180RateField;

        private decimal investorLiquidityInDays181to365RateField;

        private decimal investorLiquidityInDays365MoreRateField;

        public decimal InvestorLiquidityInDays0to1Rate
        {
            get
            {
                return this.investorLiquidityInDays0to1RateField;
            }
            set
            {
                this.investorLiquidityInDays0to1RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays2to7Rate
        {
            get
            {
                return this.investorLiquidityInDays2to7RateField;
            }
            set
            {
                this.investorLiquidityInDays2to7RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays8to30Rate
        {
            get
            {
                return this.investorLiquidityInDays8to30RateField;
            }
            set
            {
                this.investorLiquidityInDays8to30RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays31to90Rate
        {
            get
            {
                return this.investorLiquidityInDays31to90RateField;
            }
            set
            {
                this.investorLiquidityInDays31to90RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays91to180Rate
        {
            get
            {
                return this.investorLiquidityInDays91to180RateField;
            }
            set
            {
                this.investorLiquidityInDays91to180RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays181to365Rate
        {
            get
            {
                return this.investorLiquidityInDays181to365RateField;
            }
            set
            {
                this.investorLiquidityInDays181to365RateField = value;
            }
        }

        public decimal InvestorLiquidityInDays365MoreRate
        {
            get
            {
                return this.investorLiquidityInDays365MoreRateField;
            }
            set
            {
                this.investorLiquidityInDays365MoreRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexPortfolioLiquidityProfileType
    {

        private decimal portfolioLiquidityInDays0to1RateField;

        private decimal portfolioLiquidityInDays2to7RateField;

        private decimal portfolioLiquidityInDays8to30RateField;

        private decimal portfolioLiquidityInDays31to90RateField;

        private decimal portfolioLiquidityInDays91to180RateField;

        private decimal portfolioLiquidityInDays181to365RateField;

        private decimal portfolioLiquidityInDays365MoreRateField;

        private string unencumberedCashField;

        public decimal PortfolioLiquidityInDays0to1Rate
        {
            get
            {
                return this.portfolioLiquidityInDays0to1RateField;
            }
            set
            {
                this.portfolioLiquidityInDays0to1RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays2to7Rate
        {
            get
            {
                return this.portfolioLiquidityInDays2to7RateField;
            }
            set
            {
                this.portfolioLiquidityInDays2to7RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays8to30Rate
        {
            get
            {
                return this.portfolioLiquidityInDays8to30RateField;
            }
            set
            {
                this.portfolioLiquidityInDays8to30RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays31to90Rate
        {
            get
            {
                return this.portfolioLiquidityInDays31to90RateField;
            }
            set
            {
                this.portfolioLiquidityInDays31to90RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays91to180Rate
        {
            get
            {
                return this.portfolioLiquidityInDays91to180RateField;
            }
            set
            {
                this.portfolioLiquidityInDays91to180RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays181to365Rate
        {
            get
            {
                return this.portfolioLiquidityInDays181to365RateField;
            }
            set
            {
                this.portfolioLiquidityInDays181to365RateField = value;
            }
        }

        public decimal PortfolioLiquidityInDays365MoreRate
        {
            get
            {
                return this.portfolioLiquidityInDays365MoreRateField;
            }
            set
            {
                this.portfolioLiquidityInDays365MoreRateField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string UnencumberedCash
        {
            get
            {
                return this.unencumberedCashField;
            }
            set
            {
                this.unencumberedCashField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexLiquidityRiskProfileType
    {

        private ComplexPortfolioLiquidityProfileType portfolioLiquidityProfileField;

        private ComplexInvestorLiquidityProfileType investorLiquidityProfileField;

        private ComplexInvestorRedemptionType investorRedemptionField;

        private ComplexInvestorArrangementType investorArrangementField;

        private ComplexInvestorGroupType[] investorGroupsField;

        private ComplexFinancingLiquidityProfileType financingLiquidityProfileField;

        public ComplexPortfolioLiquidityProfileType PortfolioLiquidityProfile
        {
            get
            {
                return this.portfolioLiquidityProfileField;
            }
            set
            {
                this.portfolioLiquidityProfileField = value;
            }
        }

        public ComplexInvestorLiquidityProfileType InvestorLiquidityProfile
        {
            get
            {
                return this.investorLiquidityProfileField;
            }
            set
            {
                this.investorLiquidityProfileField = value;
            }
        }

        public ComplexInvestorRedemptionType InvestorRedemption
        {
            get
            {
                return this.investorRedemptionField;
            }
            set
            {
                this.investorRedemptionField = value;
            }
        }

        public ComplexInvestorArrangementType InvestorArrangement
        {
            get
            {
                return this.investorArrangementField;
            }
            set
            {
                this.investorArrangementField = value;
            }
        }

        [XmlArrayItem("InvestorGroup", IsNullable = false)]
        public ComplexInvestorGroupType[] InvestorGroups
        {
            get
            {
                return this.investorGroupsField;
            }
            set
            {
                this.investorGroupsField = value;
            }
        }

        public ComplexFinancingLiquidityProfileType FinancingLiquidityProfile
        {
            get
            {
                return this.financingLiquidityProfileField;
            }
            set
            {
                this.financingLiquidityProfileField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexCCPExposureType
    {

        private ThreeRankingType rankingField;

        private ComplexEntityIdentificationType cCPIdentificationField;

        private string cCPExposureValueField;

        public ThreeRankingType Ranking
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

        public ComplexEntityIdentificationType CCPIdentification
        {
            get
            {
                return this.cCPIdentificationField;
            }
            set
            {
                this.cCPIdentificationField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string CCPExposureValue
        {
            get
            {
                return this.cCPExposureValueField;
            }
            set
            {
                this.cCPExposureValueField = value;
            }
        }
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

        private FiveRankingType rankingField;

        private bool counterpartyExposureFlagField;

        private ComplexEntityIdentificationType counterpartyIdentificationField;

        private decimal counterpartyTotalExposureRateField;

        private bool counterpartyTotalExposureRateFieldSpecified;

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

        public bool CounterpartyExposureFlag
        {
            get
            {
                return this.counterpartyExposureFlagField;
            }
            set
            {
                this.counterpartyExposureFlagField = value;
            }
        }

        public ComplexEntityIdentificationType CounterpartyIdentification
        {
            get
            {
                return this.counterpartyIdentificationField;
            }
            set
            {
                this.counterpartyIdentificationField = value;
            }
        }

        public decimal CounterpartyTotalExposureRate
        {
            get
            {
                return this.counterpartyTotalExposureRateField;
            }
            set
            {
                this.counterpartyTotalExposureRateField = value;
            }
        }

        [XmlIgnore]
        public bool CounterpartyTotalExposureRateSpecified
        {
            get
            {
                return this.counterpartyTotalExposureRateFieldSpecified;
            }
            set
            {
                this.counterpartyTotalExposureRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAllCounterpartyCollateralType
    {

        private string allCounterpartyCollateralCashField;

        private string allCounterpartyCollateralSecuritiesField;

        private string allCounterpartyOtherCollateralPostedField;

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralCash
        {
            get
            {
                return this.allCounterpartyCollateralCashField;
            }
            set
            {
                this.allCounterpartyCollateralCashField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralSecurities
        {
            get
            {
                return this.allCounterpartyCollateralSecuritiesField;
            }
            set
            {
                this.allCounterpartyCollateralSecuritiesField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyOtherCollateralPosted
        {
            get
            {
                return this.allCounterpartyOtherCollateralPostedField;
            }
            set
            {
                this.allCounterpartyOtherCollateralPostedField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexClearedReposRateType
    {

        private decimal cCPRateField;

        private bool cCPRateFieldSpecified;

        private decimal bilateralClearingRateField;

        private bool bilateralClearingRateFieldSpecified;

        private decimal triPartyRepoClearingRateField;

        private bool triPartyRepoClearingRateFieldSpecified;

        public decimal CCPRate
        {
            get
            {
                return this.cCPRateField;
            }
            set
            {
                this.cCPRateField = value;
            }
        }

        [XmlIgnore]
        public bool CCPRateSpecified
        {
            get
            {
                return this.cCPRateFieldSpecified;
            }
            set
            {
                this.cCPRateFieldSpecified = value;
            }
        }

        public decimal BilateralClearingRate
        {
            get
            {
                return this.bilateralClearingRateField;
            }
            set
            {
                this.bilateralClearingRateField = value;
            }
        }

        [XmlIgnore]
        public bool BilateralClearingRateSpecified
        {
            get
            {
                return this.bilateralClearingRateFieldSpecified;
            }
            set
            {
                this.bilateralClearingRateFieldSpecified = value;
            }
        }

        public decimal TriPartyRepoClearingRate
        {
            get
            {
                return this.triPartyRepoClearingRateField;
            }
            set
            {
                this.triPartyRepoClearingRateField = value;
            }
        }

        [XmlIgnore]
        public bool TriPartyRepoClearingRateSpecified
        {
            get
            {
                return this.triPartyRepoClearingRateFieldSpecified;
            }
            set
            {
                this.triPartyRepoClearingRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexClearedDerivativesRateType
    {

        private decimal cCPRateField;

        private bool cCPRateFieldSpecified;

        private decimal bilateralClearingRateField;

        private bool bilateralClearingRateFieldSpecified;

        public decimal CCPRate
        {
            get
            {
                return this.cCPRateField;
            }
            set
            {
                this.cCPRateField = value;
            }
        }

        [XmlIgnore]
        public bool CCPRateSpecified
        {
            get
            {
                return this.cCPRateFieldSpecified;
            }
            set
            {
                this.cCPRateFieldSpecified = value;
            }
        }

        public decimal BilateralClearingRate
        {
            get
            {
                return this.bilateralClearingRateField;
            }
            set
            {
                this.bilateralClearingRateField = value;
            }
        }

        [XmlIgnore]
        public bool BilateralClearingRateSpecified
        {
            get
            {
                return this.bilateralClearingRateFieldSpecified;
            }
            set
            {
                this.bilateralClearingRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexMarketRate3p2Type
    {

        private decimal regulatedMarketRateField;

        private bool regulatedMarketRateFieldSpecified;

        private decimal oTCRateField;

        private bool oTCRateFieldSpecified;

        public decimal RegulatedMarketRate
        {
            get
            {
                return this.regulatedMarketRateField;
            }
            set
            {
                this.regulatedMarketRateField = value;
            }
        }

        [XmlIgnore]
        public bool RegulatedMarketRateSpecified
        {
            get
            {
                return this.regulatedMarketRateFieldSpecified;
            }
            set
            {
                this.regulatedMarketRateFieldSpecified = value;
            }
        }

        public decimal OTCRate
        {
            get
            {
                return this.oTCRateField;
            }
            set
            {
                this.oTCRateField = value;
            }
        }

        [XmlIgnore]
        public bool OTCRateSpecified
        {
            get
            {
                return this.oTCRateFieldSpecified;
            }
            set
            {
                this.oTCRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexTradingClearingMechanismType
    {

        private ComplexMarketRate3p2Type tradedSecuritiesField;

        private ComplexMarketRate3p2Type tradedDerivativesField;

        private ComplexClearedDerivativesRateType clearedDerivativesRateField;

        private ComplexClearedReposRateType clearedReposRateField;

        public ComplexMarketRate3p2Type TradedSecurities
        {
            get
            {
                return this.tradedSecuritiesField;
            }
            set
            {
                this.tradedSecuritiesField = value;
            }
        }

        public ComplexMarketRate3p2Type TradedDerivatives
        {
            get
            {
                return this.tradedDerivativesField;
            }
            set
            {
                this.tradedDerivativesField = value;
            }
        }

        public ComplexClearedDerivativesRateType ClearedDerivativesRate
        {
            get
            {
                return this.clearedDerivativesRateField;
            }
            set
            {
                this.clearedDerivativesRateField = value;
            }
        }

        public ComplexClearedReposRateType ClearedReposRate
        {
            get
            {
                return this.clearedReposRateField;
            }
            set
            {
                this.clearedReposRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexCounterpartyRiskProfileType
    {

        private ComplexTradingClearingMechanismType tradingClearingMechanismField;

        private ComplexAllCounterpartyCollateralType allCounterpartyCollateralField;

        private ComplexCounterpartyExposureType[] fundToCounterpartyExposuresField;

        private ComplexCounterpartyExposureType[] counterpartyToFundExposuresField;

        private bool clearTransactionsThroughCCPFlagField;

        private ComplexCCPExposureType[] cCPExposuresField;

        public ComplexTradingClearingMechanismType TradingClearingMechanism
        {
            get
            {
                return this.tradingClearingMechanismField;
            }
            set
            {
                this.tradingClearingMechanismField = value;
            }
        }

        public ComplexAllCounterpartyCollateralType AllCounterpartyCollateral
        {
            get
            {
                return this.allCounterpartyCollateralField;
            }
            set
            {
                this.allCounterpartyCollateralField = value;
            }
        }

        [XmlArrayItem("FundToCounterpartyExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] FundToCounterpartyExposures
        {
            get
            {
                return this.fundToCounterpartyExposuresField;
            }
            set
            {
                this.fundToCounterpartyExposuresField = value;
            }
        }

        [XmlArrayItem("CounterpartyToFundExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] CounterpartyToFundExposures
        {
            get
            {
                return this.counterpartyToFundExposuresField;
            }
            set
            {
                this.counterpartyToFundExposuresField = value;
            }
        }

        public bool ClearTransactionsThroughCCPFlag
        {
            get
            {
                return this.clearTransactionsThroughCCPFlagField;
            }
            set
            {
                this.clearTransactionsThroughCCPFlagField = value;
            }
        }

        [XmlArrayItem("CCPExposure", IsNullable = false)]
        public ComplexCCPExposureType[] CCPExposures
        {
            get
            {
                return this.cCPExposuresField;
            }
            set
            {
                this.cCPExposuresField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexVARRiskMeasureValuesType
    {

        private decimal vARValueField;

        private bool vARValueFieldSpecified;

        private VARCalculationMethodCodeTypeType vARCalculationMethodCodeTypeField;

        private bool vARCalculationMethodCodeTypeFieldSpecified;

        public decimal VARValue
        {
            get
            {
                return this.vARValueField;
            }
            set
            {
                this.vARValueField = value;
            }
        }

        [XmlIgnore]
        public bool VARValueSpecified
        {
            get
            {
                return this.vARValueFieldSpecified;
            }
            set
            {
                this.vARValueFieldSpecified = value;
            }
        }

        public VARCalculationMethodCodeTypeType VARCalculationMethodCodeType
        {
            get
            {
                return this.vARCalculationMethodCodeTypeField;
            }
            set
            {
                this.vARCalculationMethodCodeTypeField = value;
            }
        }

        [XmlIgnore]
        public bool VARCalculationMethodCodeTypeSpecified
        {
            get
            {
                return this.vARCalculationMethodCodeTypeFieldSpecified;
            }
            set
            {
                this.vARCalculationMethodCodeTypeFieldSpecified = value;
            }
        }
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

        private decimal currentMarketRiskMeasureValueField;

        private bool currentMarketRiskMeasureValueFieldSpecified;

        private decimal lowerMarketRiskMeasureValueField;

        private bool lowerMarketRiskMeasureValueFieldSpecified;

        private decimal higherMarketRiskMeasureValueField;

        private bool higherMarketRiskMeasureValueFieldSpecified;

        public decimal CurrentMarketRiskMeasureValue
        {
            get
            {
                return this.currentMarketRiskMeasureValueField;
            }
            set
            {
                this.currentMarketRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool CurrentMarketRiskMeasureValueSpecified
        {
            get
            {
                return this.currentMarketRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.currentMarketRiskMeasureValueFieldSpecified = value;
            }
        }

        public decimal LowerMarketRiskMeasureValue
        {
            get
            {
                return this.lowerMarketRiskMeasureValueField;
            }
            set
            {
                this.lowerMarketRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool LowerMarketRiskMeasureValueSpecified
        {
            get
            {
                return this.lowerMarketRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.lowerMarketRiskMeasureValueFieldSpecified = value;
            }
        }

        public decimal HigherMarketRiskMeasureValue
        {
            get
            {
                return this.higherMarketRiskMeasureValueField;
            }
            set
            {
                this.higherMarketRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool HigherMarketRiskMeasureValueSpecified
        {
            get
            {
                return this.higherMarketRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.higherMarketRiskMeasureValueFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexBucketRiskMeasureValuesType
    {

        private decimal lessFiveYearsRiskMeasureValueField;

        private bool lessFiveYearsRiskMeasureValueFieldSpecified;

        private decimal fifthteenYearsRiskMeasureValueField;

        private bool fifthteenYearsRiskMeasureValueFieldSpecified;

        private decimal moreFifthteenYearsRiskMeasureValueField;

        private bool moreFifthteenYearsRiskMeasureValueFieldSpecified;

        public decimal LessFiveYearsRiskMeasureValue
        {
            get
            {
                return this.lessFiveYearsRiskMeasureValueField;
            }
            set
            {
                this.lessFiveYearsRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool LessFiveYearsRiskMeasureValueSpecified
        {
            get
            {
                return this.lessFiveYearsRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.lessFiveYearsRiskMeasureValueFieldSpecified = value;
            }
        }

        public decimal FifthteenYearsRiskMeasureValue
        {
            get
            {
                return this.fifthteenYearsRiskMeasureValueField;
            }
            set
            {
                this.fifthteenYearsRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool FifthteenYearsRiskMeasureValueSpecified
        {
            get
            {
                return this.fifthteenYearsRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.fifthteenYearsRiskMeasureValueFieldSpecified = value;
            }
        }

        public decimal MoreFifthteenYearsRiskMeasureValue
        {
            get
            {
                return this.moreFifthteenYearsRiskMeasureValueField;
            }
            set
            {
                this.moreFifthteenYearsRiskMeasureValueField = value;
            }
        }

        [XmlIgnore]
        public bool MoreFifthteenYearsRiskMeasureValueSpecified
        {
            get
            {
                return this.moreFifthteenYearsRiskMeasureValueFieldSpecified;
            }
            set
            {
                this.moreFifthteenYearsRiskMeasureValueFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexMarketRiskMeasureType
    {

        private RiskMeasureTypeType riskMeasureTypeField;

        private object itemField;

        private string riskMeasureDescriptionField;

        public RiskMeasureTypeType RiskMeasureType
        {
            get
            {
                return this.riskMeasureTypeField;
            }
            set
            {
                this.riskMeasureTypeField = value;
            }
        }

        [XmlElement("BucketRiskMeasureValues", typeof(ComplexBucketRiskMeasureValuesType))]
        [XmlElement("RiskMeasureValue", typeof(decimal))]
        [XmlElement("VARRiskMeasureValues", typeof(ComplexVARRiskMeasureValuesType))]
        [XmlElement("VegaRiskMeasureValues", typeof(ComplexVegaRiskMeasureValuesType))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        public string RiskMeasureDescription
        {
            get
            {
                return this.riskMeasureDescriptionField;
            }
            set
            {
                this.riskMeasureDescriptionField = value;
            }
        }
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

        private string annualInvestmentReturnRateField;

        private ComplexMarketRiskMeasureType[] marketRiskMeasuresField;

        public string AnnualInvestmentReturnRate
        {
            get
            {
                return this.annualInvestmentReturnRateField;
            }
            set
            {
                this.annualInvestmentReturnRateField = value;
            }
        }

        [XmlArrayItem("MarketRiskMeasure", IsNullable = false)]
        public ComplexMarketRiskMeasureType[] MarketRiskMeasures
        {
            get
            {
                return this.marketRiskMeasuresField;
            }
            set
            {
                this.marketRiskMeasuresField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexRiskProfileType
    {

        private ComplexMarketRiskProfileType marketRiskProfileField;

        private ComplexCounterpartyRiskProfileType counterpartyRiskProfileField;

        private ComplexLiquidityRiskProfileType liquidityRiskProfileField;

        private ComplexOperationalRiskType operationalRiskField;

        public ComplexMarketRiskProfileType MarketRiskProfile
        {
            get
            {
                return this.marketRiskProfileField;
            }
            set
            {
                this.marketRiskProfileField = value;
            }
        }

        public ComplexCounterpartyRiskProfileType CounterpartyRiskProfile
        {
            get
            {
                return this.counterpartyRiskProfileField;
            }
            set
            {
                this.counterpartyRiskProfileField = value;
            }
        }

        public ComplexLiquidityRiskProfileType LiquidityRiskProfile
        {
            get
            {
                return this.liquidityRiskProfileField;
            }
            set
            {
                this.liquidityRiskProfileField = value;
            }
        }

        public ComplexOperationalRiskType OperationalRisk
        {
            get
            {
                return this.operationalRiskField;
            }
            set
            {
                this.operationalRiskField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexCompanyDominantInfluenceType
    {

        private ComplexEntityIdentificationType companyIdentificationField;

        private TransactionTypeType transactionTypeField;

        private string otherTransactionTypeDescriptionField;

        private decimal votingRightsRateField;

        public ComplexEntityIdentificationType CompanyIdentification
        {
            get
            {
                return this.companyIdentificationField;
            }
            set
            {
                this.companyIdentificationField = value;
            }
        }

        public TransactionTypeType TransactionType
        {
            get
            {
                return this.transactionTypeField;
            }
            set
            {
                this.transactionTypeField = value;
            }
        }

        public string OtherTransactionTypeDescription
        {
            get
            {
                return this.otherTransactionTypeDescriptionField;
            }
            set
            {
                this.otherTransactionTypeDescriptionField = value;
            }
        }

        public decimal VotingRightsRate
        {
            get
            {
                return this.votingRightsRateField;
            }
            set
            {
                this.votingRightsRateField = value;
            }
        }
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

        private string exposureCurrencyField;

        private string longPositionValueField;

        private string shortPositionValueField;

        public string ExposureCurrency
        {
            get
            {
                return this.exposureCurrencyField;
            }
            set
            {
                this.exposureCurrencyField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string LongPositionValue
        {
            get
            {
                return this.longPositionValueField;
            }
            set
            {
                this.longPositionValueField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string ShortPositionValue
        {
            get
            {
                return this.shortPositionValueField;
            }
            set
            {
                this.shortPositionValueField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAssetTypeTurnoverType
    {

        private TurnoverSubAssetTypeType turnoverSubAssetTypeField;

        private string marketValueField;

        private string notionalValueField;

        public TurnoverSubAssetTypeType TurnoverSubAssetType
        {
            get
            {
                return this.turnoverSubAssetTypeField;
            }
            set
            {
                this.turnoverSubAssetTypeField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string MarketValue
        {
            get
            {
                return this.marketValueField;
            }
            set
            {
                this.marketValueField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string NotionalValue
        {
            get
            {
                return this.notionalValueField;
            }
            set
            {
                this.notionalValueField = value;
            }
        }
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

        private SubAssetTypeType subAssetTypeField;

        private string grossValueField;

        private string longValueField;

        private string shortValueField;

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
        public string GrossValue
        {
            get
            {
                return this.grossValueField;
            }
            set
            {
                this.grossValueField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string LongValue
        {
            get
            {
                return this.longValueField;
            }
            set
            {
                this.longValueField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string ShortValue
        {
            get
            {
                return this.shortValueField;
            }
            set
            {
                this.shortValueField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexIndividualExposureType
    {

        private ComplexAssetTypeExposureType[] assetTypeExposuresField;

        private ComplexAssetTypeTurnoverType[] assetTypeTurnoversField;

        private ComplexCurrencyExposureType[] currencyExposuresField;

        private ComplexCompanyDominantInfluenceType[] companiesDominantInfluenceField;

        [XmlArrayItem("AssetTypeExposure", IsNullable = false)]
        public ComplexAssetTypeExposureType[] AssetTypeExposures
        {
            get
            {
                return this.assetTypeExposuresField;
            }
            set
            {
                this.assetTypeExposuresField = value;
            }
        }

        [XmlArrayItem("AssetTypeTurnover", IsNullable = false)]
        public ComplexAssetTypeTurnoverType[] AssetTypeTurnovers
        {
            get
            {
                return this.assetTypeTurnoversField;
            }
            set
            {
                this.assetTypeTurnoversField = value;
            }
        }

        [XmlArrayItem("CurrencyExposure", IsNullable = false)]
        public ComplexCurrencyExposureType[] CurrencyExposures
        {
            get
            {
                return this.currencyExposuresField;
            }
            set
            {
                this.currencyExposuresField = value;
            }
        }

        [XmlArrayItem("CompanyDominantInfluence", IsNullable = false)]
        public ComplexCompanyDominantInfluenceType[] CompaniesDominantInfluence
        {
            get
            {
                return this.companiesDominantInfluenceField;
            }
            set
            {
                this.companiesDominantInfluenceField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFIndividualInfoType
    {

        private ComplexIndividualExposureType individualExposureField;

        private ComplexRiskProfileType riskProfileField;

        private ComplexStressTestsType stressTestsField;

        public ComplexIndividualExposureType IndividualExposure
        {
            get
            {
                return this.individualExposureField;
            }
            set
            {
                this.individualExposureField = value;
            }
        }

        public ComplexRiskProfileType RiskProfile
        {
            get
            {
                return this.riskProfileField;
            }
            set
            {
                this.riskProfileField = value;
            }
        }

        public ComplexStressTestsType StressTests
        {
            get
            {
                return this.stressTestsField;
            }
            set
            {
                this.stressTestsField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexInvestorConcentrationType
    {

        private decimal mainBeneficialOwnersRateField;

        private decimal professionalInvestorConcentrationRateField;

        private decimal retailInvestorConcentrationRateField;

        public decimal MainBeneficialOwnersRate
        {
            get
            {
                return this.mainBeneficialOwnersRateField;
            }
            set
            {
                this.mainBeneficialOwnersRateField = value;
            }
        }

        public decimal ProfessionalInvestorConcentrationRate
        {
            get
            {
                return this.professionalInvestorConcentrationRateField;
            }
            set
            {
                this.professionalInvestorConcentrationRateField = value;
            }
        }

        public decimal RetailInvestorConcentrationRate
        {
            get
            {
                return this.retailInvestorConcentrationRateField;
            }
            set
            {
                this.retailInvestorConcentrationRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexThreePrincipalMarketType
    {

        private ThreeRankingType rankingField;

        private ComplexMarketIdentificationWithNOTType marketIdentificationField;

        private string aggregatedValueAmountField;

        public ThreeRankingType Ranking
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
    public partial class ComplexMarketIdentificationWithoutNOTType
    {

        private MarketCodeTypeWithoutNOTType marketCodeTypeField;

        private string marketCodeField;

        public MarketCodeTypeWithoutNOTType MarketCodeType
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
    public enum MarketCodeTypeWithoutNOTType
    {

        MIC,

        OTC,

        XXX,
    }

    [Serializable]
    public partial class ComplexPortfolioConcentrationType
    {

        private FiveRankingType rankingField;

        private AssetTypeType assetTypeField;

        private PositionTypeType positionTypeField;

        private bool positionTypeFieldSpecified;

        private ComplexMarketIdentificationWithoutNOTType marketIdentificationField;

        private string aggregatedValueAmountField;

        private decimal aggregatedValueRateField;

        private bool aggregatedValueRateFieldSpecified;

        private ComplexEntityIdentificationType counterpartyIdentificationField;

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

        public AssetTypeType AssetType
        {
            get
            {
                return this.assetTypeField;
            }
            set
            {
                this.assetTypeField = value;
            }
        }

        public PositionTypeType PositionType
        {
            get
            {
                return this.positionTypeField;
            }
            set
            {
                this.positionTypeField = value;
            }
        }

        [XmlIgnore]
        public bool PositionTypeSpecified
        {
            get
            {
                return this.positionTypeFieldSpecified;
            }
            set
            {
                this.positionTypeFieldSpecified = value;
            }
        }

        public ComplexMarketIdentificationWithoutNOTType MarketIdentification
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

        public decimal AggregatedValueRate
        {
            get
            {
                return this.aggregatedValueRateField;
            }
            set
            {
                this.aggregatedValueRateField = value;
            }
        }

        [XmlIgnore]
        public bool AggregatedValueRateSpecified
        {
            get
            {
                return this.aggregatedValueRateFieldSpecified;
            }
            set
            {
                this.aggregatedValueRateFieldSpecified = value;
            }
        }

        public ComplexEntityIdentificationType CounterpartyIdentification
        {
            get
            {
                return this.counterpartyIdentificationField;
            }
            set
            {
                this.counterpartyIdentificationField = value;
            }
        }
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

        private ComplexPortfolioConcentrationType[] portfolioConcentrationsField;

        private TypicalPositionSizeType typicalPositionSizeField;

        private bool typicalPositionSizeFieldSpecified;

        private ComplexThreePrincipalMarketType[] aIFPrincipalMarketsField;

        private ComplexInvestorConcentrationType investorConcentrationField;

        [XmlArrayItem("PortfolioConcentration", IsNullable = false)]
        public ComplexPortfolioConcentrationType[] PortfolioConcentrations
        {
            get
            {
                return this.portfolioConcentrationsField;
            }
            set
            {
                this.portfolioConcentrationsField = value;
            }
        }

        public TypicalPositionSizeType TypicalPositionSize
        {
            get
            {
                return this.typicalPositionSizeField;
            }
            set
            {
                this.typicalPositionSizeField = value;
            }
        }

        [XmlIgnore]
        public bool TypicalPositionSizeSpecified
        {
            get
            {
                return this.typicalPositionSizeFieldSpecified;
            }
            set
            {
                this.typicalPositionSizeFieldSpecified = value;
            }
        }

        [XmlArrayItem("AIFPrincipalMarket", IsNullable = false)]
        public ComplexThreePrincipalMarketType[] AIFPrincipalMarkets
        {
            get
            {
                return this.aIFPrincipalMarketsField;
            }
            set
            {
                this.aIFPrincipalMarketsField = value;
            }
        }

        public ComplexInvestorConcentrationType InvestorConcentration
        {
            get
            {
                return this.investorConcentrationField;
            }
            set
            {
                this.investorConcentrationField = value;
            }
        }
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

        private TenRankingType rankingField;

        private AssetMacroTypeType assetMacroTypeField;

        private SubAssetTypeType subAssetTypeField;

        private bool subAssetTypeFieldSpecified;

        private PositionTypeType positionTypeField;

        private bool positionTypeFieldSpecified;

        private string aggregatedValueAmountField;

        private decimal aggregatedValueRateField;

        private bool aggregatedValueRateFieldSpecified;

        private ComplexEntityIdentificationType counterpartyIdentificationField;

        public TenRankingType Ranking
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

        public AssetMacroTypeType AssetMacroType
        {
            get
            {
                return this.assetMacroTypeField;
            }
            set
            {
                this.assetMacroTypeField = value;
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

        [XmlIgnore]
        public bool SubAssetTypeSpecified
        {
            get
            {
                return this.subAssetTypeFieldSpecified;
            }
            set
            {
                this.subAssetTypeFieldSpecified = value;
            }
        }

        public PositionTypeType PositionType
        {
            get
            {
                return this.positionTypeField;
            }
            set
            {
                this.positionTypeField = value;
            }
        }

        [XmlIgnore]
        public bool PositionTypeSpecified
        {
            get
            {
                return this.positionTypeFieldSpecified;
            }
            set
            {
                this.positionTypeFieldSpecified = value;
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

        public decimal AggregatedValueRate
        {
            get
            {
                return this.aggregatedValueRateField;
            }
            set
            {
                this.aggregatedValueRateField = value;
            }
        }

        [XmlIgnore]
        public bool AggregatedValueRateSpecified
        {
            get
            {
                return this.aggregatedValueRateFieldSpecified;
            }
            set
            {
                this.aggregatedValueRateFieldSpecified = value;
            }
        }

        public ComplexEntityIdentificationType CounterpartyIdentification
        {
            get
            {
                return this.counterpartyIdentificationField;
            }
            set
            {
                this.counterpartyIdentificationField = value;
            }
        }
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

        private decimal africaAUMRateField;

        private decimal asiaPacificAUMRateField;

        private decimal europeAUMRateField;

        private decimal eEAAUMRateField;

        private decimal middleEastAUMRateField;

        private decimal northAmericaAUMRateField;

        private decimal southAmericaAUMRateField;

        private decimal supraNationalAUMRateField;

        public decimal AfricaAUMRate
        {
            get
            {
                return this.africaAUMRateField;
            }
            set
            {
                this.africaAUMRateField = value;
            }
        }

        public decimal AsiaPacificAUMRate
        {
            get
            {
                return this.asiaPacificAUMRateField;
            }
            set
            {
                this.asiaPacificAUMRateField = value;
            }
        }

        public decimal EuropeAUMRate
        {
            get
            {
                return this.europeAUMRateField;
            }
            set
            {
                this.europeAUMRateField = value;
            }
        }

        public decimal EEAAUMRate
        {
            get
            {
                return this.eEAAUMRateField;
            }
            set
            {
                this.eEAAUMRateField = value;
            }
        }

        public decimal MiddleEastAUMRate
        {
            get
            {
                return this.middleEastAUMRateField;
            }
            set
            {
                this.middleEastAUMRateField = value;
            }
        }

        public decimal NorthAmericaAUMRate
        {
            get
            {
                return this.northAmericaAUMRateField;
            }
            set
            {
                this.northAmericaAUMRateField = value;
            }
        }

        public decimal SouthAmericaAUMRate
        {
            get
            {
                return this.southAmericaAUMRateField;
            }
            set
            {
                this.southAmericaAUMRateField = value;
            }
        }

        public decimal SupraNationalAUMRate
        {
            get
            {
                return this.supraNationalAUMRateField;
            }
            set
            {
                this.supraNationalAUMRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexNAVGeographicalFocusType
    {

        private decimal africaNAVRateField;

        private decimal asiaPacificNAVRateField;

        private decimal europeNAVRateField;

        private decimal eEANAVRateField;

        private decimal middleEastNAVRateField;

        private decimal northAmericaNAVRateField;

        private decimal southAmericaNAVRateField;

        private decimal supraNationalNAVRateField;

        public decimal AfricaNAVRate
        {
            get
            {
                return this.africaNAVRateField;
            }
            set
            {
                this.africaNAVRateField = value;
            }
        }

        public decimal AsiaPacificNAVRate
        {
            get
            {
                return this.asiaPacificNAVRateField;
            }
            set
            {
                this.asiaPacificNAVRateField = value;
            }
        }

        public decimal EuropeNAVRate
        {
            get
            {
                return this.europeNAVRateField;
            }
            set
            {
                this.europeNAVRateField = value;
            }
        }

        public decimal EEANAVRate
        {
            get
            {
                return this.eEANAVRateField;
            }
            set
            {
                this.eEANAVRateField = value;
            }
        }

        public decimal MiddleEastNAVRate
        {
            get
            {
                return this.middleEastNAVRateField;
            }
            set
            {
                this.middleEastNAVRateField = value;
            }
        }

        public decimal NorthAmericaNAVRate
        {
            get
            {
                return this.northAmericaNAVRateField;
            }
            set
            {
                this.northAmericaNAVRateField = value;
            }
        }

        public decimal SouthAmericaNAVRate
        {
            get
            {
                return this.southAmericaNAVRateField;
            }
            set
            {
                this.southAmericaNAVRateField = value;
            }
        }

        public decimal SupraNationalNAVRate
        {
            get
            {
                return this.supraNationalNAVRateField;
            }
            set
            {
                this.supraNationalNAVRateField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIIInstrumentIdentificationType
    {

        private string aIIExchangeCodeField;

        private string aIIProductCodeField;

        private AIIDerivativeTypeType aIIDerivativeTypeField;

        private AIIPutCallIdentifierType aIIPutCallIdentifierField;

        private DateTime aIIExpiryDateField;

        private decimal aIIStrikePriceField;

        public string AIIExchangeCode
        {
            get
            {
                return this.aIIExchangeCodeField;
            }
            set
            {
                this.aIIExchangeCodeField = value;
            }
        }

        public string AIIProductCode
        {
            get
            {
                return this.aIIProductCodeField;
            }
            set
            {
                this.aIIProductCodeField = value;
            }
        }

        public AIIDerivativeTypeType AIIDerivativeType
        {
            get
            {
                return this.aIIDerivativeTypeField;
            }
            set
            {
                this.aIIDerivativeTypeField = value;
            }
        }

        public AIIPutCallIdentifierType AIIPutCallIdentifier
        {
            get
            {
                return this.aIIPutCallIdentifierField;
            }
            set
            {
                this.aIIPutCallIdentifierField = value;
            }
        }

        [XmlElement(DataType = "date")]
        public DateTime AIIExpiryDate
        {
            get
            {
                return this.aIIExpiryDateField;
            }
            set
            {
                this.aIIExpiryDateField = value;
            }
        }

        public decimal AIIStrikePrice
        {
            get
            {
                return this.aIIStrikePriceField;
            }
            set
            {
                this.aIIStrikePriceField = value;
            }
        }
    }

    [Serializable]
    public enum AIIDerivativeTypeType
    {

        O,

        F,
    }

    [Serializable]
    public enum AIIPutCallIdentifierType
    {

        P,

        C,

        F,
    }

    [Serializable]
    public partial class ComplexMainInstrumentTradedType
    {

        private FiveRankingType rankingField;

        private SubAssetTypeType subAssetTypeField;

        private InstrumentCodeTypeType instrumentCodeTypeField;

        private bool instrumentCodeTypeFieldSpecified;

        private string instrumentNameField;

        private object itemField;

        private string positionValueField;

        private PositionTypeType positionTypeField;

        private bool positionTypeFieldSpecified;

        private decimal shortPositionHedgingRateField;

        private bool shortPositionHedgingRateFieldSpecified;

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

        public InstrumentCodeTypeType InstrumentCodeType
        {
            get
            {
                return this.instrumentCodeTypeField;
            }
            set
            {
                this.instrumentCodeTypeField = value;
            }
        }

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified
        {
            get
            {
                return this.instrumentCodeTypeFieldSpecified;
            }
            set
            {
                this.instrumentCodeTypeFieldSpecified = value;
            }
        }

        public string InstrumentName
        {
            get
            {
                return this.instrumentNameField;
            }
            set
            {
                this.instrumentNameField = value;
            }
        }

        [XmlElement("AIIInstrumentIdentification", typeof(ComplexAIIInstrumentIdentificationType))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string PositionValue
        {
            get
            {
                return this.positionValueField;
            }
            set
            {
                this.positionValueField = value;
            }
        }

        public PositionTypeType PositionType
        {
            get
            {
                return this.positionTypeField;
            }
            set
            {
                this.positionTypeField = value;
            }
        }

        [XmlIgnore]
        public bool PositionTypeSpecified
        {
            get
            {
                return this.positionTypeFieldSpecified;
            }
            set
            {
                this.positionTypeFieldSpecified = value;
            }
        }

        public decimal ShortPositionHedgingRate
        {
            get
            {
                return this.shortPositionHedgingRateField;
            }
            set
            {
                this.shortPositionHedgingRateField = value;
            }
        }

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified
        {
            get
            {
                return this.shortPositionHedgingRateFieldSpecified;
            }
            set
            {
                this.shortPositionHedgingRateFieldSpecified = value;
            }
        }
    }

    [Serializable]
    public enum InstrumentCodeTypeType
    {

        ISIN,

        AII,

        NONE,
    }

    [Serializable]
    public partial class ComplexOtherFundStrategyType
    {

        private OtherFundStrategyTypeType otherFundStrategyTypeField;

        private bool primaryStrategyFlagField;

        private decimal strategyNAVRateField;

        private bool strategyNAVRateFieldSpecified;

        private string strategyTypeOtherDescriptionField;

        public OtherFundStrategyTypeType OtherFundStrategyType
        {
            get
            {
                return this.otherFundStrategyTypeField;
            }
            set
            {
                this.otherFundStrategyTypeField = value;
            }
        }

        public bool PrimaryStrategyFlag
        {
            get
            {
                return this.primaryStrategyFlagField;
            }
            set
            {
                this.primaryStrategyFlagField = value;
            }
        }

        public decimal StrategyNAVRate
        {
            get
            {
                return this.strategyNAVRateField;
            }
            set
            {
                this.strategyNAVRateField = value;
            }
        }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified
        {
            get
            {
                return this.strategyNAVRateFieldSpecified;
            }
            set
            {
                this.strategyNAVRateFieldSpecified = value;
            }
        }

        public string StrategyTypeOtherDescription
        {
            get
            {
                return this.strategyTypeOtherDescriptionField;
            }
            set
            {
                this.strategyTypeOtherDescriptionField = value;
            }
        }
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

        private FundOfFundsStrategyTypeType fundOfFundsStrategyTypeField;

        private bool primaryStrategyFlagField;

        private decimal strategyNAVRateField;

        private bool strategyNAVRateFieldSpecified;

        private string strategyTypeOtherDescriptionField;

        public FundOfFundsStrategyTypeType FundOfFundsStrategyType
        {
            get
            {
                return this.fundOfFundsStrategyTypeField;
            }
            set
            {
                this.fundOfFundsStrategyTypeField = value;
            }
        }

        public bool PrimaryStrategyFlag
        {
            get
            {
                return this.primaryStrategyFlagField;
            }
            set
            {
                this.primaryStrategyFlagField = value;
            }
        }

        public decimal StrategyNAVRate
        {
            get
            {
                return this.strategyNAVRateField;
            }
            set
            {
                this.strategyNAVRateField = value;
            }
        }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified
        {
            get
            {
                return this.strategyNAVRateFieldSpecified;
            }
            set
            {
                this.strategyNAVRateFieldSpecified = value;
            }
        }

        public string StrategyTypeOtherDescription
        {
            get
            {
                return this.strategyTypeOtherDescriptionField;
            }
            set
            {
                this.strategyTypeOtherDescriptionField = value;
            }
        }
    }

    [Serializable]
    public enum FundOfFundsStrategyTypeType
    {

        FOFS_FHFS,

        FOFS_PRIV,

        OTHR_FOFS,
    }

    [Serializable]
    public partial class ComplexRealEstateFundStrategyType
    {

        private RealEstateFundStrategyTypeType realEstateFundStrategyTypeField;

        private bool primaryStrategyFlagField;

        private decimal strategyNAVRateField;

        private bool strategyNAVRateFieldSpecified;

        private string strategyTypeOtherDescriptionField;

        public RealEstateFundStrategyTypeType RealEstateFundStrategyType
        {
            get
            {
                return this.realEstateFundStrategyTypeField;
            }
            set
            {
                this.realEstateFundStrategyTypeField = value;
            }
        }

        public bool PrimaryStrategyFlag
        {
            get
            {
                return this.primaryStrategyFlagField;
            }
            set
            {
                this.primaryStrategyFlagField = value;
            }
        }

        public decimal StrategyNAVRate
        {
            get
            {
                return this.strategyNAVRateField;
            }
            set
            {
                this.strategyNAVRateField = value;
            }
        }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified
        {
            get
            {
                return this.strategyNAVRateFieldSpecified;
            }
            set
            {
                this.strategyNAVRateFieldSpecified = value;
            }
        }

        public string StrategyTypeOtherDescription
        {
            get
            {
                return this.strategyTypeOtherDescriptionField;
            }
            set
            {
                this.strategyTypeOtherDescriptionField = value;
            }
        }
    }

    [Serializable]
    public enum RealEstateFundStrategyTypeType
    {

        RESL_REST,

        COML_REST,

        INDL_REST,

        MULT_REST,

        OTHR_REST,
    }

    [Serializable]
    public partial class ComplexPrivateEquityFundStrategyType
    {

        private PrivateEquityFundStrategyTypeType privateEquityFundStrategyTypeField;

        private bool primaryStrategyFlagField;

        private decimal strategyNAVRateField;

        private bool strategyNAVRateFieldSpecified;

        private string strategyTypeOtherDescriptionField;

        public PrivateEquityFundStrategyTypeType PrivateEquityFundStrategyType
        {
            get
            {
                return this.privateEquityFundStrategyTypeField;
            }
            set
            {
                this.privateEquityFundStrategyTypeField = value;
            }
        }

        public bool PrimaryStrategyFlag
        {
            get
            {
                return this.primaryStrategyFlagField;
            }
            set
            {
                this.primaryStrategyFlagField = value;
            }
        }

        public decimal StrategyNAVRate
        {
            get
            {
                return this.strategyNAVRateField;
            }
            set
            {
                this.strategyNAVRateField = value;
            }
        }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified
        {
            get
            {
                return this.strategyNAVRateFieldSpecified;
            }
            set
            {
                this.strategyNAVRateFieldSpecified = value;
            }
        }

        public string StrategyTypeOtherDescription
        {
            get
            {
                return this.strategyTypeOtherDescriptionField;
            }
            set
            {
                this.strategyTypeOtherDescriptionField = value;
            }
        }
    }

    [Serializable]
    public enum PrivateEquityFundStrategyTypeType
    {

        VENT_CAPL,

        GRTH_CAPL,

        MZNE_CAPL,

        MULT_PEQF,

        OTHR_PEQF,
    }

    [Serializable]
    public partial class ComplexHedgeFundStrategyType
    {

        private HedgeFundStrategyTypeType hedgeFundStrategyTypeField;

        private bool primaryStrategyFlagField;

        private decimal strategyNAVRateField;

        private bool strategyNAVRateFieldSpecified;

        private string strategyTypeOtherDescriptionField;

        public HedgeFundStrategyTypeType HedgeFundStrategyType
        {
            get
            {
                return this.hedgeFundStrategyTypeField;
            }
            set
            {
                this.hedgeFundStrategyTypeField = value;
            }
        }

        public bool PrimaryStrategyFlag
        {
            get
            {
                return this.primaryStrategyFlagField;
            }
            set
            {
                this.primaryStrategyFlagField = value;
            }
        }

        public decimal StrategyNAVRate
        {
            get
            {
                return this.strategyNAVRateField;
            }
            set
            {
                this.strategyNAVRateField = value;
            }
        }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified
        {
            get
            {
                return this.strategyNAVRateFieldSpecified;
            }
            set
            {
                this.strategyNAVRateFieldSpecified = value;
            }
        }

        public string StrategyTypeOtherDescription
        {
            get
            {
                return this.strategyTypeOtherDescriptionField;
            }
            set
            {
                this.strategyTypeOtherDescriptionField = value;
            }
        }
    }

    [Serializable]
    public enum HedgeFundStrategyTypeType
    {

        EQTY_LGBS,

        EQTY_LGST,

        EQTY_MTNL,

        EQTY_STBS,

        RELV_FXIA,

        RELV_CBAR,

        RELV_VLAR,

        EVDR_DSRS,

        EVDR_RAMA,

        EVDR_EYSS,

        CRED_LGST,

        CRED_ABLG,

        MACR_MACR,

        MANF_CTAF,

        MANF_CTAQ,

        MULT_HFND,

        OTHR_HFND,
    }

    [Serializable]
    public partial class ComplexMasterAIFIdentificationType
    {

        private string aIFNameField;

        private ComplexAIFNationalIdentifierType aIFIdentifierNCAField;

        public string AIFName
        {
            get
            {
                return this.aIFNameField;
            }
            set
            {
                this.aIFNameField = value;
            }
        }

        public ComplexAIFNationalIdentifierType AIFIdentifierNCA
        {
            get
            {
                return this.aIFIdentifierNCAField;
            }
            set
            {
                this.aIFIdentifierNCAField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFNationalIdentifierType
    {

        private string reportingMemberStateField;

        private string aIFNationalCodeField;

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

        public string AIFNationalCode
        {
            get
            {
                return this.aIFNationalCodeField;
            }
            set
            {
                this.aIFNationalCodeField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFDescriptionType
    {

        private AIFMasterFeederStatusType aIFMasterFeederStatusField;

        private ComplexMasterAIFIdentificationType[] masterAIFsIdentificationField;

        private ComplexEntityIdentificationType[] primeBrokersField;

        private ComplexBaseCurrencyDescriptionType aIFBaseCurrencyDescriptionField;

        private string aIFNetAssetValueField;

        private string firstFundingSourceCountryField;

        private string secondFundingSourceCountryField;

        private string thirdFundingSourceCountryField;

        private AIFTypeType predominantAIFTypeField;

        private ComplexHedgeFundStrategyType[] hedgeFundInvestmentStrategiesField;

        private ComplexPrivateEquityFundStrategyType[] privateEquityFundInvestmentStrategiesField;

        private ComplexRealEstateFundStrategyType[] realEstateFundInvestmentStrategiesField;

        private ComplexFundOfFundsStrategyType[] fundOfFundsInvestmentStrategiesField;

        private ComplexOtherFundStrategyType[] otherFundInvestmentStrategiesField;

        private string hFTTransactionNumberField;

        private string hFTBuySellMarketValueField;

        public AIFMasterFeederStatusType AIFMasterFeederStatus
        {
            get
            {
                return this.aIFMasterFeederStatusField;
            }
            set
            {
                this.aIFMasterFeederStatusField = value;
            }
        }

        [XmlArrayItem("MasterAIFIdentification", IsNullable = false)]
        public ComplexMasterAIFIdentificationType[] MasterAIFsIdentification
        {
            get
            {
                return this.masterAIFsIdentificationField;
            }
            set
            {
                this.masterAIFsIdentificationField = value;
            }
        }

        [XmlArrayItem("PrimeBrokerIdentification", IsNullable = false)]
        public ComplexEntityIdentificationType[] PrimeBrokers
        {
            get
            {
                return this.primeBrokersField;
            }
            set
            {
                this.primeBrokersField = value;
            }
        }

        public ComplexBaseCurrencyDescriptionType AIFBaseCurrencyDescription
        {
            get
            {
                return this.aIFBaseCurrencyDescriptionField;
            }
            set
            {
                this.aIFBaseCurrencyDescriptionField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string AIFNetAssetValue
        {
            get
            {
                return this.aIFNetAssetValueField;
            }
            set
            {
                this.aIFNetAssetValueField = value;
            }
        }

        public string FirstFundingSourceCountry
        {
            get
            {
                return this.firstFundingSourceCountryField;
            }
            set
            {
                this.firstFundingSourceCountryField = value;
            }
        }

        public string SecondFundingSourceCountry
        {
            get
            {
                return this.secondFundingSourceCountryField;
            }
            set
            {
                this.secondFundingSourceCountryField = value;
            }
        }

        public string ThirdFundingSourceCountry
        {
            get
            {
                return this.thirdFundingSourceCountryField;
            }
            set
            {
                this.thirdFundingSourceCountryField = value;
            }
        }

        public AIFTypeType PredominantAIFType
        {
            get
            {
                return this.predominantAIFTypeField;
            }
            set
            {
                this.predominantAIFTypeField = value;
            }
        }

        [XmlArrayItem("HedgeFundStrategy", IsNullable = false)]
        public ComplexHedgeFundStrategyType[] HedgeFundInvestmentStrategies
        {
            get
            {
                return this.hedgeFundInvestmentStrategiesField;
            }
            set
            {
                this.hedgeFundInvestmentStrategiesField = value;
            }
        }

        [XmlArrayItem("PrivateEquityFundInvestmentStrategy", IsNullable = false)]
        public ComplexPrivateEquityFundStrategyType[] PrivateEquityFundInvestmentStrategies
        {
            get
            {
                return this.privateEquityFundInvestmentStrategiesField;
            }
            set
            {
                this.privateEquityFundInvestmentStrategiesField = value;
            }
        }

        [XmlArrayItem("RealEstateFundStrategy", IsNullable = false)]
        public ComplexRealEstateFundStrategyType[] RealEstateFundInvestmentStrategies
        {
            get
            {
                return this.realEstateFundInvestmentStrategiesField;
            }
            set
            {
                this.realEstateFundInvestmentStrategiesField = value;
            }
        }

        [XmlArrayItem("FundOfFundsStrategy", IsNullable = false)]
        public ComplexFundOfFundsStrategyType[] FundOfFundsInvestmentStrategies
        {
            get
            {
                return this.fundOfFundsInvestmentStrategiesField;
            }
            set
            {
                this.fundOfFundsInvestmentStrategiesField = value;
            }
        }

        [XmlArrayItem("OtherFundStrategy", IsNullable = false)]
        public ComplexOtherFundStrategyType[] OtherFundInvestmentStrategies
        {
            get
            {
                return this.otherFundInvestmentStrategiesField;
            }
            set
            {
                this.otherFundInvestmentStrategiesField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string HFTTransactionNumber
        {
            get
            {
                return this.hFTTransactionNumberField;
            }
            set
            {
                this.hFTTransactionNumberField = value;
            }
        }

        [XmlElement(DataType = "integer")]
        public string HFTBuySellMarketValue
        {
            get
            {
                return this.hFTBuySellMarketValueField;
            }
            set
            {
                this.hFTBuySellMarketValueField = value;
            }
        }
    }

    [Serializable]
    public enum AIFMasterFeederStatusType
    {

        MASTER,

        FEEDER,

        NONE,
    }

    [Serializable]
    public enum AIFTypeType
    {

        HFND,

        PEQF,

        REST,

        FOFS,

        OTHR,

        NONE,
    }

    [Serializable]
    public partial class ComplexShareClassIdentifierType
    {

        private string shareClassNationalCodeField;

        private string shareClassIdentifierISINField;

        private string shareClassIdentifierCUSIPField;

        private string shareClassIdentifierSEDOLField;

        private string shareClassIdentifierTickerField;

        private string shareClassIdentifierRICField;

        private string shareClassNameField;

        public string ShareClassNationalCode
        {
            get
            {
                return this.shareClassNationalCodeField;
            }
            set
            {
                this.shareClassNationalCodeField = value;
            }
        }

        public string ShareClassIdentifierISIN
        {
            get
            {
                return this.shareClassIdentifierISINField;
            }
            set
            {
                this.shareClassIdentifierISINField = value;
            }
        }

        public string ShareClassIdentifierCUSIP
        {
            get
            {
                return this.shareClassIdentifierCUSIPField;
            }
            set
            {
                this.shareClassIdentifierCUSIPField = value;
            }
        }

        public string ShareClassIdentifierSEDOL
        {
            get
            {
                return this.shareClassIdentifierSEDOLField;
            }
            set
            {
                this.shareClassIdentifierSEDOLField = value;
            }
        }

        public string ShareClassIdentifierTicker
        {
            get
            {
                return this.shareClassIdentifierTickerField;
            }
            set
            {
                this.shareClassIdentifierTickerField = value;
            }
        }

        public string ShareClassIdentifierRIC
        {
            get
            {
                return this.shareClassIdentifierRICField;
            }
            set
            {
                this.shareClassIdentifierRICField = value;
            }
        }

        public string ShareClassName
        {
            get
            {
                return this.shareClassNameField;
            }
            set
            {
                this.shareClassNameField = value;
            }
        }
    }

    [Serializable]
    public partial class ComplexAIFIdentifierType
    {

        private string aIFIdentifierLEIField;

        private string aIFIdentifierISINField;

        private string aIFIdentifierCUSIPField;

        private string aIFIdentifierSEDOLField;

        private string aIFIdentifierTickerField;

        private string aIFIdentifierRICField;

        private string aIFIdentifierECBField;

        private ComplexAIFNationalIdentifierType oldAIFIdentifierNCAField;

        public string AIFIdentifierLEI
        {
            get
            {
                return this.aIFIdentifierLEIField;
            }
            set
            {
                this.aIFIdentifierLEIField = value;
            }
        }

        public string AIFIdentifierISIN
        {
            get
            {
                return this.aIFIdentifierISINField;
            }
            set
            {
                this.aIFIdentifierISINField = value;
            }
        }

        public string AIFIdentifierCUSIP
        {
            get
            {
                return this.aIFIdentifierCUSIPField;
            }
            set
            {
                this.aIFIdentifierCUSIPField = value;
            }
        }

        public string AIFIdentifierSEDOL
        {
            get
            {
                return this.aIFIdentifierSEDOLField;
            }
            set
            {
                this.aIFIdentifierSEDOLField = value;
            }
        }

        public string AIFIdentifierTicker
        {
            get
            {
                return this.aIFIdentifierTickerField;
            }
            set
            {
                this.aIFIdentifierTickerField = value;
            }
        }

        public string AIFIdentifierRIC
        {
            get
            {
                return this.aIFIdentifierRICField;
            }
            set
            {
                this.aIFIdentifierRICField = value;
            }
        }

        public string AIFIdentifierECB
        {
            get
            {
                return this.aIFIdentifierECBField;
            }
            set
            {
                this.aIFIdentifierECBField = value;
            }
        }

        public ComplexAIFNationalIdentifierType OldAIFIdentifierNCA
        {
            get
            {
                return this.oldAIFIdentifierNCAField;
            }
            set
            {
                this.oldAIFIdentifierNCAField = value;
            }
        }
    }
}
