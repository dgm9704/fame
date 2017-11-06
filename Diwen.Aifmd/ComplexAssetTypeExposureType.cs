namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAssetTypeExposureType
    {

        public SubAssetTypeType SubAssetType { get; set; }

        [XmlElement(DataType = "integer")]
        public string GrossValue { get; set; }

        [XmlElement(DataType = "integer")]
        public string LongValue { get; set; }

        [XmlElement(DataType = "integer")]
        public string ShortValue { get; set; }
    }
}
