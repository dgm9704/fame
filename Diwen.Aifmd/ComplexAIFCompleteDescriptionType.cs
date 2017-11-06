namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFCompleteDescriptionType
    {
        public ComplexAIFPrincipalInfoType AIFPrincipalInfo {get; set;}
        public ComplexAIFIndividualInfoType AIFIndividualInfo {get; set;}

        public ComplexAIFLeverageInfoType AIFLeverageInfo {get; set;}
    }
}
