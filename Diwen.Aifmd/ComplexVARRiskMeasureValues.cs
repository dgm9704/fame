namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexVARRiskMeasureValues
    {

        public decimal VARValue {get; set;}

        [XmlIgnore]
        public bool VARValueSpecified {get; set;}

        public VARCalculationMethodCode VARCalculationMethodCodeType {get; set;}

        [XmlIgnore]
        public bool VARCalculationMethodCodeTypeSpecified {get; set;}
    }
}
