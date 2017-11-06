namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorGroupType
    {

        public InvestorGroupTypeType InvestorGroupType { get; set; }

        public decimal InvestorGroupRate { get; set; }
    }
}
