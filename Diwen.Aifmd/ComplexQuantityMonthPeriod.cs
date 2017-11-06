namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexQuantityMonthPeriodType
    {
        [XmlElement(DataType = "integer")]
        public string QuantityJanuary {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityFebruary {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityMarch {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityApril {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityMay {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityJune {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityJuly {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityAugust {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantitySeptember {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityOctober {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityNovember {get; set;}

        [XmlElement(DataType = "integer")]
        public string QuantityDecember {get; set;}
        
    }
}
