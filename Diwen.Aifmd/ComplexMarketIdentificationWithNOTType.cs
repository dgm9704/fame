namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexMarketIdentificationWithNOTType
    {

        public MarketCodeTypeWithNOTType MarketCodeType {get; set;}

        public string MarketCode {get; set;}
    }
}
