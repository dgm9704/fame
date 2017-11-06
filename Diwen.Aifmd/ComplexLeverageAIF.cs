namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexLeverageAIF
    {
        public decimal GrossMethodRate {get; set;}

        public decimal CommitmentMethodRate {get; set;}
    }
}
