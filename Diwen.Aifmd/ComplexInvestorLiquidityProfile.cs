namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorLiquidityProfile
    {

        public decimal InvestorLiquidityInDays0to1Rate {get; set;}

        public decimal InvestorLiquidityInDays2to7Rate {get; set;}

        public decimal InvestorLiquidityInDays8to30Rate {get; set;}

        public decimal InvestorLiquidityInDays31to90Rate {get; set;}

        public decimal InvestorLiquidityInDays91to180Rate {get; set;}

        public decimal InvestorLiquidityInDays181to365Rate {get; set;}

        public decimal InvestorLiquidityInDays365MoreRate {get; set;}
    }
}
