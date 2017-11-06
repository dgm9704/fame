namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexInvestorConcentrationType
    {

        public decimal MainBeneficialOwnersRate { get; set; }

        public decimal ProfessionalInvestorConcentrationRate { get; set; }

        public decimal RetailInvestorConcentrationRate { get; set; }
    }
}
