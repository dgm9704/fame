namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexInvestorIlliquidAssetArrangement
    {

        public decimal SidePocketRate {get; set;}

        [XmlIgnore]
        public bool SidePocketRateSpecified {get; set;}

        public decimal GatesRate {get; set;}

        [XmlIgnore]
        public bool GatesRateSpecified {get; set;}

        public decimal DealingSuspensionRate {get; set;}

        [XmlIgnore]
        public bool DealingSuspensionRateSpecified {get; set;}

        public ComplexOtherArrangement OtherArrangement {get; set;}

        public decimal TotalArrangementRate {get; set;}

        [XmlIgnore]
        public bool TotalArrangementRateSpecified {get; set;}
    }
}
