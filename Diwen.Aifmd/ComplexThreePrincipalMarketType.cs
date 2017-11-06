namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexThreePrincipalMarketType
    {

        public ThreeRankingType Ranking { get; set; }

        public ComplexMarketIdentificationWithNOTType MarketIdentification { get; set; }

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount { get; set; }
    }
}
