namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexInvestorPreferentialTreatment
    {

        public bool InvestorPreferentialTreatmentFlag {get; set;}

        public bool DisclosureTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool DisclosureTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool LiquidityTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool LiquidityTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool FeeTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool FeeTermsPreferentialTreatmentFlagSpecified {get; set;}

        public bool OtherTermsPreferentialTreatmentFlag {get; set;}

        [XmlIgnore]
        public bool OtherTermsPreferentialTreatmentFlagSpecified {get; set;}
    }
}
