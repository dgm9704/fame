namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCCPExposure
    {

        public ThreeRanking Ranking {get; set;}

        public ComplexEntityIdentification CCPIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string CCPExposureValue {get; set;}
    }
}
