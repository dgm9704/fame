namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexFivePrincipalMarket
    {

        public FiveRanking Ranking {get; set;}

        public ComplexMarketIdentificationWithNOT MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }
}
