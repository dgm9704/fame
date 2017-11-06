namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFIndividualInfoType
    {

        public ComplexIndividualExposureType IndividualExposure { get; set; }

        public ComplexRiskProfileType RiskProfile { get; set; }

        public ComplexStressTestsType StressTests { get; set; }
    }
}
