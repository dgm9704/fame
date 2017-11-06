namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPrincipalExposure
    {

        public TenRanking Ranking {get; set;}

        public AssetMacroType AssetMacroType {get; set;}

        public SubAssetType SubAssetType {get; set;}

        [XmlIgnore]
        public bool SubAssetTypeSpecified {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}

        public decimal AggregatedValueRate {get; set;}

        [XmlIgnore]
        public bool AggregatedValueRateSpecified {get; set;}

        public ComplexEntityIdentification CounterpartyIdentification {get; set;}
    }
}
