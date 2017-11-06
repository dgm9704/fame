namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexLiquidityRiskProfileType
    {

        public ComplexPortfolioLiquidityProfileType PortfolioLiquidityProfile { get; set; }

        public ComplexInvestorLiquidityProfileType InvestorLiquidityProfile { get; set; }

        public ComplexInvestorRedemptionType InvestorRedemption { get; set; }

        public ComplexInvestorArrangementType InvestorArrangement { get; set; }

        [XmlArrayItem("InvestorGroup", IsNullable = false)]
        public ComplexInvestorGroupType[] InvestorGroups { get; set; }

        public ComplexFinancingLiquidityProfileType FinancingLiquidityProfile { get; set; }
    }
}
