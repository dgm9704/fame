namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexRiskProfileType
    {

        public ComplexMarketRiskProfileType MarketRiskProfile { get; set; }

        public ComplexCounterpartyRiskProfileType CounterpartyRiskProfile { get; set; }

        public ComplexLiquidityRiskProfileType LiquidityRiskProfile { get; set; }

        public ComplexOperationalRiskType OperationalRisk { get; set; }
    }
}
