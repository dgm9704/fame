namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexThreePrincipalMarket
    {

        public ThreeRanking Ranking {get; set;}

        public ComplexMarketIdentificationWithNOT MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }
}
