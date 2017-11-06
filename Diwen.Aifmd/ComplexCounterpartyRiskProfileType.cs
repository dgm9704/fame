namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexCounterpartyRiskProfileType
    {

        public ComplexTradingClearingMechanismType TradingClearingMechanism { get; set; }

        public ComplexAllCounterpartyCollateralType AllCounterpartyCollateral { get; set; }

        [XmlArrayItem("FundToCounterpartyExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] FundToCounterpartyExposures { get; set; }

        [XmlArrayItem("CounterpartyToFundExposure", IsNullable = false)]
        public ComplexCounterpartyExposureType[] CounterpartyToFundExposures { get; set; }

        public bool ClearTransactionsThroughCCPFlag { get; set; }

        [XmlArrayItem("CCPExposure", IsNullable = false)]
        public ComplexCCPExposureType[] CCPExposures { get; set; }
    }
}
