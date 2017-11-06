namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPortfolioConcentrationType
    {

        public FiveRankingType Ranking { get; set; }

        public AssetTypeType AssetType { get; set; }

        public PositionTypeType PositionType { get; set; }

        [XmlIgnore]
        public bool PositionTypeSpecified { get; set; }

        public ComplexMarketIdentificationWithoutNOTType MarketIdentification { get; set; }

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount { get; set; }

        public decimal AggregatedValueRate { get; set; }

        [XmlIgnore]
        public bool AggregatedValueRateSpecified { get; set; }

        public ComplexEntityIdentificationType CounterpartyIdentification { get; set; }
    }
}
