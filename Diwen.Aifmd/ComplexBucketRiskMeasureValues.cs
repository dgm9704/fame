namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexBucketRiskMeasureValues
    {

        public decimal LessFiveYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool LessFiveYearsRiskMeasureValueSpecified {get; set;}

        public decimal FifthteenYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool FifthteenYearsRiskMeasureValueSpecified {get; set;}

        public decimal MoreFifthteenYearsRiskMeasureValue {get; set;}

        [XmlIgnore]
        public bool MoreFifthteenYearsRiskMeasureValueSpecified {get; set;}
    }
}
