namespace Schemas
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    public partial class ComplexOtherFundStrategyType
    {

        public OtherFundStrategyType OtherFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public enum OtherFundStrategyType
    {

        OTHR_COMF,

        OTHR_EQYF,

        OTHR_FXIF,

        OTHR_INFF,

        OTHR_OTHF,
    }

    [Serializable]
    public partial class ComplexFundOfFundsStrategyType
    {

        public FundOfFundsStrategyType FundOfFundsStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }

    [Serializable]
    public partial class ComplexRealEstateFundStrategyType
    {

        public RealEstateFundStrategyType RealEstateFundStrategyType {get; set;}

        public bool PrimaryStrategyFlag {get; set;}

        public decimal StrategyNAVRate {get; set;}

        [XmlIgnore]
        public bool StrategyNAVRateSpecified {get; set;}

        public string StrategyTypeOtherDescription {get; set;}
    }
}
