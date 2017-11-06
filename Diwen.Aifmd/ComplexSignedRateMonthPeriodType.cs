namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexSignedRateMonthPeriodType
    {
        public decimal RateJanuary {get; set;}

        [XmlIgnore]
        public bool RateJanuarySpecified {get; set;}

        public decimal RateFebruary {get; set;}

        [XmlIgnore]
        public bool RateFebruarySpecified {get; set;}

        public decimal RateMarch {get; set;}

        [XmlIgnore]
        public bool RateMarchSpecified {get; set;}

        public decimal RateApril {get; set;}

        [XmlIgnore]
        public bool RateAprilSpecified {get; set;}
        public decimal RateMay {get; set;}

        [XmlIgnore]
        public bool RateMaySpecified {get; set;}

        public decimal RateJune {get; set;}

        [XmlIgnore]
        public bool RateJuneSpecified {get; set;}

        public decimal RateJuly {get; set;}

        [XmlIgnore]
        public bool RateJulySpecified {get; set;}

        public decimal RateAugust {get; set;}

        [XmlIgnore]
        public bool RateAugustSpecified {get; set;}

        public decimal RateSeptember {get; set;}

        [XmlIgnore]
        public bool RateSeptemberSpecified {get; set;}

        public decimal RateOctober {get; set;}

        [XmlIgnore]
        public bool RateOctoberSpecified {get; set;}

        public decimal RateNovember {get; set;}

        [XmlIgnore]
        public bool RateNovemberSpecified {get; set;}

        public decimal RateDecember {get; set;}

        [XmlIgnore]
        public bool RateDecemberSpecified {get; set;}
    }
}
