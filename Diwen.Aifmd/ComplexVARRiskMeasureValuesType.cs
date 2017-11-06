namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexVARRiskMeasureValuesType
    {

        public decimal VARValue { get; set; }

        [XmlIgnore]
        public bool VARValueSpecified { get; set; }

        public VARCalculationMethodCodeTypeType VARCalculationMethodCodeType { get; set; }

        [XmlIgnore]
        public bool VARCalculationMethodCodeTypeSpecified { get; set; }
    }
}
