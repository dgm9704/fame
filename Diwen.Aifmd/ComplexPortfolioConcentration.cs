namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPortfolioConcentration
    {

        public FiveRanking Ranking {get; set;}

        public AssetType AssetType {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        public ComplexMarketIdentificationWithoutNOT MarketIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}

        public decimal AggregatedValueRate {get; set;}

        [XmlIgnore]
        public bool AggregatedValueRateSpecified {get; set;}

        public ComplexEntityIdentification CounterpartyIdentification {get; set;}
    }
}
