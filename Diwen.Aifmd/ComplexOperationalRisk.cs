namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexOperationalRisk
    {

        [XmlElement(DataType = "integer")]
        public string TotalOpenPositions {get; set;}

        public ComplexHistoricalRiskProfile HistoricalRiskProfile {get; set;}
    }
}
