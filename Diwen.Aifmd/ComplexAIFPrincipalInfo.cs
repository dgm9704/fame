namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFPrincipalInfoType
    {
        public ComplexAIFIdentifierType AIFIdentification {get; set;}
        public bool ShareClassFlag {get; set;}

        [XmlArrayItem("ShareClassIdentifier", IsNullable = false)]
        public ComplexShareClassIdentifier[] ShareClassIdentification {get; set;}

        public ComplexAIFDescriptionType AIFDescription {get; set;}

        [XmlArrayItem("MainInstrumentTraded", IsNullable = false)]
        public ComplexMainInstrumentTradedType[] MainInstrumentsTraded {get; set;}

        public ComplexNAVGeographicalFocusType NAVGeographicalFocus {get; set;}

        public ComplexAUMGeographicalFocusType AUMGeographicalFocus {get; set;}

        [XmlArrayItem("PrincipalExposure", IsNullable = false)]
        public ComplexPrincipalExposureType[] PrincipalExposures {get; set;}

        public ComplexMostImportantConcentrationType MostImportantConcentration {get; set;}
    }
}
