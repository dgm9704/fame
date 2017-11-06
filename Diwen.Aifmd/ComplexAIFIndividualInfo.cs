namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFIndividualInfo
    {

        public ComplexIndividualExposure IndividualExposure {get; set;}

        public ComplexRiskProfile RiskProfile {get; set;}

        public ComplexStressTests StressTests {get; set;}
    }
}
