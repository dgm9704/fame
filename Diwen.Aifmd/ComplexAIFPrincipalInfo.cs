namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFPrincipalInfo
    {
        public ComplexAIFIdentifier AIFIdentification {get; set;}
        public bool ShareClassFlag {get; set;}

        [XmlArrayItem("ShareClassIdentifier", IsNullable = false)]
        public ComplexShareClassIdentifier[] ShareClassIdentification {get; set;}

        public ComplexAIFDescription AIFDescription {get; set;}

        [XmlArrayItem("MainInstrumentTraded", IsNullable = false)]
        public ComplexMainInstrumentTraded[] MainInstrumentsTraded {get; set;}

        public ComplexNAVGeographicalFocus NAVGeographicalFocus {get; set;}

        public ComplexAUMGeographicalFocus AUMGeographicalFocus {get; set;}

        [XmlArrayItem("PrincipalExposure", IsNullable = false)]
        public ComplexPrincipalExposure[] PrincipalExposures {get; set;}

        public ComplexMostImportantConcentration MostImportantConcentration {get; set;}
    }
}
