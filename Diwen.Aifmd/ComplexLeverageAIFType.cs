namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexLeverageAIFType
    {
        public decimal GrossMethodRate {get; set;}

        public decimal CommitmentMethodRate {get; set;}
    }
}
