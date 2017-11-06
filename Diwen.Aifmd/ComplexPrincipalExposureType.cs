namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPrincipalExposureType
    {

        public TenRankingType Ranking { get; set; }

        public AssetMacroTypeType AssetMacroType { get; set; }

        public SubAssetTypeType SubAssetType { get; set; }

        [XmlIgnore]
        public bool SubAssetTypeSpecified { get; set; }

        public PositionTypeType PositionType { get; set; }

        [XmlIgnore]
        public bool PositionTypeSpecified { get; set; }

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount { get; set; }

        public decimal AggregatedValueRate { get; set; }

        [XmlIgnore]
        public bool AggregatedValueRateSpecified { get; set; }

        public ComplexEntityIdentificationType CounterpartyIdentification { get; set; }
    }
}
