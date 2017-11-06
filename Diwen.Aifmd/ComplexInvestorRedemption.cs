namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexInvestorRedemption
    {

        public bool ProvideWithdrawalRightsFlag {get; set;}

        public InvestorRedemptionFrequency InvestorRedemptionFrequency {get; set;}

        [XmlIgnore]
        public bool InvestorRedemptionFrequencySpecified {get; set;}

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionNoticePeriod {get; set;}

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionLockUpPeriod {get; set;}
    }
}
