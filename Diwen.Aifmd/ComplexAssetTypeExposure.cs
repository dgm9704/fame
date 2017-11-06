namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAssetTypeExposure
    {

        public SubAssetType SubAssetType {get; set;}

        [XmlElement(DataType = "integer")]
        public string GrossValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string LongValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string ShortValue {get; set;}
    }
}
