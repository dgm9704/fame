namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMarketRate3p2
    {

        public decimal RegulatedMarketRate {get; set;}

        [XmlIgnore]
        public bool RegulatedMarketRateSpecified {get; set;}

        public decimal OTCRate {get; set;}

        [XmlIgnore]
        public bool OTCRateSpecified {get; set;}
    }
}
