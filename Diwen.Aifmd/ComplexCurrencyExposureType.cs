namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCurrencyExposureType
    {

        public string ExposureCurrency { get; set; }

        [XmlElement(DataType = "integer")]
        public string LongPositionValue { get; set; }

        [XmlElement(DataType = "integer")]
        public string ShortPositionValue { get; set; }
    }
}