namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPrincipalInstrumentType
    {

        public FiveRankingType Ranking {get; set;}

        public SubAssetTypeType SubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }
}
