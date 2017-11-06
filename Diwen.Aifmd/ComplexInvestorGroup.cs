namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorGroup
    {

        public InvestorGroupType InvestorGroupType {get; set;}

        public decimal InvestorGroupRate {get; set;}
    }
}
