namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorArrangementType
    {

        public ComplexInvestorIlliquidAssetArrangementType InvestorIlliquidAssetArrangement { get; set; }

        public ComplexInvestorPreferentialTreatmentType InvestorPreferentialTreatment { get; set; }
    }
}
