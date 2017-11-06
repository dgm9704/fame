namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCounterpartyExposureType
    {

        public FiveRankingType Ranking { get; set; }

        public bool CounterpartyExposureFlag { get; set; }

        public ComplexEntityIdentificationType CounterpartyIdentification { get; set; }

        public decimal CounterpartyTotalExposureRate { get; set; }

        [XmlIgnore]
        public bool CounterpartyTotalExposureRateSpecified { get; set; }
    }
}
