namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCounterpartyExposure
    {

        public FiveRanking Ranking {get; set;}

        public bool CounterpartyExposureFlag {get; set;}

        public ComplexEntityIdentification CounterpartyIdentification {get; set;}

        public decimal CounterpartyTotalExposureRate {get; set;}

        [XmlIgnore]
        public bool CounterpartyTotalExposureRateSpecified {get; set;}
    }
}
