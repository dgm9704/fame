namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexMarketIdentificationWithoutNOTType
    {

        public MarketCodeTypeWithoutNOTType MarketCodeType { get; set; }

        public string MarketCode { get; set; }
    }
}
