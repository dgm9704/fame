namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFDescription
    {
        public AIFMasterFeederStatus AIFMasterFeederStatus {get; set;}

        [XmlArrayItem("MasterAIFIdentification", IsNullable = false)]
        public ComplexMasterAIFIdentification[] MasterAIFsIdentification {get; set;}

        [XmlArrayItem("PrimeBrokerIdentification", IsNullable = false)]
        public ComplexEntityIdentification[] PrimeBrokers {get; set;}

        public ComplexBaseCurrencyDescription AIFBaseCurrencyDescription {get; set;}
        [XmlElement(DataType = "integer")]
        public string AIFNetAssetValue {get; set;}

        public string FirstFundingSourceCountry {get; set;}

        public string SecondFundingSourceCountry {get; set;}
        public string ThirdFundingSourceCountry {get; set;}

        public AIFType PredominantAIFType {get; set;}
        [XmlArrayItem("HedgeFundStrategy", IsNullable = false)]
        public ComplexHedgeFundStrategy[] HedgeFundInvestmentStrategies {get; set;}

        [XmlArrayItem("PrivateEquityFundInvestmentStrategy", IsNullable = false)]
        public ComplexPrivateEquityFundStrategy[] PrivateEquityFundInvestmentStrategies {get; set;}

        [XmlArrayItem("RealEstateFundStrategy", IsNullable = false)]
        public ComplexRealEstateFundStrategy[] RealEstateFundInvestmentStrategies {get; set;}

        [XmlArrayItem("FundOfFundsStrategy", IsNullable = false)]
        public ComplexFundOfFundsStrategy[] FundOfFundsInvestmentStrategies {get; set;}

        [XmlArrayItem("OtherFundStrategy", IsNullable = false)]
        public ComplexOtherFundStrategy[] OtherFundInvestmentStrategies {get; set;}
        [XmlElement(DataType = "integer")]
        public string HFTTransactionNumber {get; set;}

        [XmlElement(DataType = "integer")]
        public string HFTBuySellMarketValue {get; set;}
    }
}