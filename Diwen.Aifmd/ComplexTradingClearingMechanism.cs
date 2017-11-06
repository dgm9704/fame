namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexTradingClearingMechanism
    {

        public ComplexMarketRate3p2 TradedSecurities {get; set;}

        public ComplexMarketRate3p2 TradedDerivatives {get; set;}

        public ComplexClearedDerivativesRate ClearedDerivativesRate {get; set;}

        public ComplexClearedReposRate ClearedReposRate {get; set;}
    }
}
