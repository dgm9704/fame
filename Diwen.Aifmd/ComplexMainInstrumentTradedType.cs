namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMainInstrumentTradedType
    {

        public FiveRankingType Ranking { get; set; }

        public SubAssetTypeType SubAssetType { get; set; }

        public InstrumentCodeTypeType InstrumentCodeType { get; set; }

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified { get; set; }

        public string InstrumentName { get; set; }

        [XmlElement("AIIInstrumentIdentification", typeof(ComplexAIIInstrumentIdentificationType))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item { get; set; }

        [XmlElement(DataType = "integer")]
        public string PositionValue { get; set; }

        public PositionTypeType PositionType { get; set; }

        [XmlIgnore]
        public bool PositionTypeSpecified { get; set; }

        public decimal ShortPositionHedgingRate { get; set; }

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified { get; set; }
    }
}
