namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexMarketIdentificationWithoutNOT
    {

        public MarketCodeTypeWithoutNOT MarketCodeType {get; set;}

        public string MarketCode {get; set;}
    }
}
