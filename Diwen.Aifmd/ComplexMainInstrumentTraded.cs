namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMainInstrumentTraded
    {

        public FiveRanking Ranking {get; set;}

        public SubAssetType SubAssetType {get; set;}

        public InstrumentCodeType InstrumentCodeType {get; set;}

        [XmlIgnore]
        public bool InstrumentCodeTypeSpecified {get; set;}

        public string InstrumentName {get; set;}

        [XmlElement("AIIInstrumentIdentification", typeof(ComplexAIIInstrumentIdentification))]
        [XmlElement("ISINInstrumentIdentification", typeof(string))]
        public object Item {get; set;}

        [XmlElement(DataType = "integer")]
        public string PositionValue {get; set;}

        public PositionType PositionType {get; set;}

        [XmlIgnore]
        public bool PositionTypeSpecified {get; set;}

        public decimal ShortPositionHedgingRate {get; set;}

        [XmlIgnore]
        public bool ShortPositionHedgingRateSpecified {get; set;}
    }
}
