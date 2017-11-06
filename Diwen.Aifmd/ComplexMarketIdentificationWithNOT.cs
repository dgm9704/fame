namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexMarketIdentificationWithNOT
    {

        public MarketCodeTypeWithNOT MarketCodeType {get; set;}

        public string MarketCode {get; set;}
    }
}
