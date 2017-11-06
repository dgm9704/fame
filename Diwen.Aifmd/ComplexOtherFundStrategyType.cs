namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexOtherFundStrategyType
    {

        public OtherFundStrategyTypeType OtherFundStrategyType { get; set; }

        public bool PrimaryStrategyFlag { get; set; }

        public decimal StrategyNAVRate { get; set; }

        [XmlIgnore]
        public bool StrategyNAVRateSpecified { get; set; }

        public string StrategyTypeOtherDescription { get; set; }
    }
}
