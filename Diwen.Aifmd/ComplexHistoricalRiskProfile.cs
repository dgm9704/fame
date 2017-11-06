namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexHistoricalRiskProfile
    {
        public ComplexSignedRateMonthPeriod GrossInvestmentReturnsRate {get; set;}

        public ComplexSignedRateMonthPeriod NetInvestmentReturnsRate {get; set;}

        public ComplexSignedRateMonthPeriod NAVChangeRate {get; set;}

        public ComplexQuantityMonthPeriodType Subscription {get; set;}

        public ComplexQuantityMonthPeriodType Redemption {get; set;}
    }
}
