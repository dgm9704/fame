namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorArrangement
    {

        public ComplexInvestorIlliquidAssetArrangement InvestorIlliquidAssetArrangement {get; set;}

        public ComplexInvestorPreferentialTreatment InvestorPreferentialTreatment {get; set;}
    }
}
