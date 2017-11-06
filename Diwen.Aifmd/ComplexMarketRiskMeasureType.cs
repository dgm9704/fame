namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMarketRiskMeasureType
    {

        public RiskMeasureTypeType RiskMeasureType { get; set; }

        [XmlElement("BucketRiskMeasureValues", typeof(ComplexBucketRiskMeasureValuesType))]
        [XmlElement("RiskMeasureValue", typeof(decimal))]
        [XmlElement("VARRiskMeasureValues", typeof(ComplexVARRiskMeasureValuesType))]
        [XmlElement("VegaRiskMeasureValues", typeof(ComplexVegaRiskMeasureValuesType))]
        public object Item { get; set; }

        public string RiskMeasureDescription { get; set; }
    }
}
