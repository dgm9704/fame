namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexFivePrincipalMarketType
    {

        public FiveRankingType Ranking {get; set;}

        public ComplexMarketIdentificationWithNOTType MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }
}
