namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexInvestorConcentration
    {

        public decimal MainBeneficialOwnersRate {get; set;}

        public decimal ProfessionalInvestorConcentrationRate {get; set;}

        public decimal RetailInvestorConcentrationRate {get; set;}
    }
}
