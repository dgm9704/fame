namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexHistoricalRiskProfileType
    {

        public ComplexSignedRateMonthPeriodType GrossInvestmentReturnsRate { get; set; }

        public ComplexSignedRateMonthPeriodType NetInvestmentReturnsRate { get; set; }

        public ComplexSignedRateMonthPeriodType NAVChangeRate { get; set; }

        public ComplexQuantityMonthPeriodType Subscription { get; set; }

        public ComplexQuantityMonthPeriodType Redemption { get; set; }
    }
}
