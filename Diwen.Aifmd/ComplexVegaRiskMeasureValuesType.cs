namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexVegaRiskMeasureValuesType
    {

        public decimal CurrentMarketRiskMeasureValue { get; set; }

        [XmlIgnore]
        public bool CurrentMarketRiskMeasureValueSpecified { get; set; }

        public decimal LowerMarketRiskMeasureValue { get; set; }

        [XmlIgnore]
        public bool LowerMarketRiskMeasureValueSpecified { get; set; }

        public decimal HigherMarketRiskMeasureValue { get; set; }

        [XmlIgnore]
        public bool HigherMarketRiskMeasureValueSpecified { get; set; }
    }
}
