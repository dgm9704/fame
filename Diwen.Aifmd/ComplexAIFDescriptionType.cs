namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFDescriptionType
    {
        public AIFMasterFeederStatusType AIFMasterFeederStatus {get; set;}

        [XmlArrayItem("MasterAIFIdentification", IsNullable = false)]
        public ComplexMasterAIFIdentificationType[] MasterAIFsIdentification {get; set;}

        [XmlArrayItem("PrimeBrokerIdentification", IsNullable = false)]
        public ComplexEntityIdentificationType[] PrimeBrokers {get; set;}

        public ComplexBaseCurrencyDescriptionType AIFBaseCurrencyDescription {get; set;}
        [XmlElement(DataType = "integer")]
        public string AIFNetAssetValue {get; set;}

        public string FirstFundingSourceCountry {get; set;}

        public string SecondFundingSourceCountry {get; set;}
        public string ThirdFundingSourceCountry {get; set;}

        public AIFTypeType PredominantAIFType {get; set;}
        [XmlArrayItem("HedgeFundStrategy", IsNullable = false)]
        public ComplexHedgeFundStrategyType[] HedgeFundInvestmentStrategies {get; set;}

        [XmlArrayItem("PrivateEquityFundInvestmentStrategy", IsNullable = false)]
        public ComplexPrivateEquityFundStrategyType[] PrivateEquityFundInvestmentStrategies {get; set;}

        [XmlArrayItem("RealEstateFundStrategy", IsNullable = false)]
        public ComplexRealEstateFundStrategyType[] RealEstateFundInvestmentStrategies {get; set;}

        [XmlArrayItem("FundOfFundsStrategy", IsNullable = false)]
        public ComplexFundOfFundsStrategyType[] FundOfFundsInvestmentStrategies {get; set;}

        [XmlArrayItem("OtherFundStrategy", IsNullable = false)]
        public ComplexOtherFundStrategyType[] OtherFundInvestmentStrategies {get; set;}
        [XmlElement(DataType = "integer")]
        public string HFTTransactionNumber {get; set;}

        [XmlElement(DataType = "integer")]
        public string HFTBuySellMarketValue {get; set;}
    }
}