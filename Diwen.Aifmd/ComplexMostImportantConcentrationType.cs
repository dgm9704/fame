namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMostImportantConcentrationType
    {

        [XmlArrayItem("PortfolioConcentration", IsNullable = false)]
        public ComplexPortfolioConcentrationType[] PortfolioConcentrations { get; set; }

        public TypicalPositionSizeType TypicalPositionSize { get; set; }

        [XmlIgnore]
        public bool TypicalPositionSizeSpecified { get; set; }

        [XmlArrayItem("AIFPrincipalMarket", IsNullable = false)]
        public ComplexThreePrincipalMarketType[] AIFPrincipalMarkets { get; set; }

        public ComplexInvestorConcentrationType InvestorConcentration { get; set; }
    }
}
