namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexOperationalRiskType
    {

        [XmlElement(DataType = "integer")]
        public string TotalOpenPositions { get; set; }

        public ComplexHistoricalRiskProfileType HistoricalRiskProfile { get; set; }
    }
}
