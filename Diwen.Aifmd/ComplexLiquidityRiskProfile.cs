namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexLiquidityRiskProfile
    {

        public ComplexPortfolioLiquidityProfile PortfolioLiquidityProfile {get; set;}

        public ComplexInvestorLiquidityProfile InvestorLiquidityProfile {get; set;}

        public ComplexInvestorRedemption InvestorRedemption {get; set;}

        public ComplexInvestorArrangement InvestorArrangement {get; set;}

        [XmlArrayItem("InvestorGroup", IsNullable = false)]
        public ComplexInvestorGroupType[] InvestorGroups {get; set;}

        public ComplexFinancingLiquidityProfile FinancingLiquidityProfile {get; set;}
    }
}
