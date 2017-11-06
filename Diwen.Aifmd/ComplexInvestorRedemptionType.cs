namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexInvestorRedemptionType
    {

        public bool ProvideWithdrawalRightsFlag { get; set; }

        public InvestorRedemptionFrequencyType InvestorRedemptionFrequency { get; set; }

        [XmlIgnore]
        public bool InvestorRedemptionFrequencySpecified { get; set; }

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionNoticePeriod { get; set; }

        [XmlElement(DataType = "integer")]
        public string InvestorRedemptionLockUpPeriod { get; set; }
    }
}
