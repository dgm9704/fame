namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexRiskProfile
    {

        public ComplexMarketRiskProfile MarketRiskProfile {get; set;}

        public ComplexCounterpartyRiskProfile CounterpartyRiskProfile {get; set;}

        public ComplexLiquidityRiskProfile LiquidityRiskProfile {get; set;}

        public ComplexOperationalRisk OperationalRisk {get; set;}
    }
}
