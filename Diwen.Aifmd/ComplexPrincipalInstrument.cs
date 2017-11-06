namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPrincipalInstrument
    {

        public FiveRanking Ranking {get; set;}

        public SubAssetType SubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string AggregatedValueAmount {get; set;}
    }
}
