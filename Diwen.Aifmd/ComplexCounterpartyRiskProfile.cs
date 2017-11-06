namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCounterpartyRiskProfile
    {

        public ComplexTradingClearingMechanism TradingClearingMechanism {get; set;}

        public ComplexAllCounterpartyCollateral AllCounterpartyCollateral {get; set;}

        [XmlArrayItem("FundToCounterpartyExposure", IsNullable = false)]
        public ComplexCounterpartyExposure[] FundToCounterpartyExposures {get; set;}

        [XmlArrayItem("CounterpartyToFundExposure", IsNullable = false)]
        public ComplexCounterpartyExposure[] CounterpartyToFundExposures {get; set;}

        public bool ClearTransactionsThroughCCPFlag {get; set;}

        [XmlArrayItem("CCPExposure", IsNullable = false)]
        public ComplexCCPExposure[] CCPExposures {get; set;}
    }
}
