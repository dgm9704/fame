namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAssetTypeTurnoverType
    {

        public TurnoverSubAssetTypeType TurnoverSubAssetType { get; set; }

        [XmlElement(DataType = "integer")]
        public string MarketValue { get; set; }

        [XmlElement(DataType = "integer")]
        public string NotionalValue { get; set; }
    }
}
