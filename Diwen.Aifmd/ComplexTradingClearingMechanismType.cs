namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexTradingClearingMechanismType
    {

        public ComplexMarketRate3p2Type TradedSecurities { get; set; }

        public ComplexMarketRate3p2Type TradedDerivatives { get; set; }

        public ComplexClearedDerivativesRateType ClearedDerivativesRate { get; set; }

        public ComplexClearedReposRateType ClearedReposRate { get; set; }
    }
}
