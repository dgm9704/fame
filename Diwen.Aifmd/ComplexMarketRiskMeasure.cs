namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMarketRiskMeasure
    {

        public RiskMeasure RiskMeasureType {get; set;}

        [XmlElement("BucketRiskMeasureValues", typeof(ComplexBucketRiskMeasureValues))]
        [XmlElement("RiskMeasureValue", typeof(decimal))]
        [XmlElement("VARRiskMeasureValues", typeof(ComplexVARRiskMeasureValues))]
        [XmlElement("VegaRiskMeasureValues", typeof(ComplexVegaRiskMeasureValues))]
        public object Item {get; set;}

        public string RiskMeasureDescription {get; set;}
    }
}
