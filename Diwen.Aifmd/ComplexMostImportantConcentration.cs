namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMostImportantConcentration
    {

        [XmlArrayItem("PortfolioConcentration", IsNullable = false)]
        public ComplexPortfolioConcentration[] PortfolioConcentrations {get; set;}

        public TypicalPositionSize TypicalPositionSize {get; set;}

        [XmlIgnore]
        public bool TypicalPositionSizeSpecified {get; set;}

        [XmlArrayItem("AIFPrincipalMarket", IsNullable = false)]
        public ComplexThreePrincipalMarket[] AIFPrincipalMarkets {get; set;}

        public ComplexInvestorConcentration InvestorConcentration {get; set;}
    }
}
