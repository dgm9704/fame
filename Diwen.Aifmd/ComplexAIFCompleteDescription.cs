namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFCompleteDescription
    {
        public ComplexAIFPrincipalInfo AIFPrincipalInfo {get; set;}
        public ComplexAIFIndividualInfo AIFIndividualInfo {get; set;}

        public ComplexAIFLeverageInfo AIFLeverageInfo {get; set;}
    }
}
