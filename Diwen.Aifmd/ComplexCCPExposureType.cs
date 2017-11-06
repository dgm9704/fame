namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCCPExposureType
    {

        public ThreeRankingType Ranking { get; set; }

        public ComplexEntityIdentificationType CCPIdentification { get; set; }

        [XmlElement(DataType = "integer")]
        public string CCPExposureValue { get; set; }
    }
}
