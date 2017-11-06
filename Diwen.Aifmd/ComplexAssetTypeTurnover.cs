namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAssetTypeTurnover
    {

        public TurnoverSubAssetType TurnoverSubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string MarketValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string NotionalValue {get; set;}
    }
}
