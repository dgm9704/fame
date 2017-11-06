namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFMCompleteDescriptionType
    {

        public ComplexAIFMIdentifierType AIFMIdentifier {get; set;}

        [XmlArrayItem("AIFMFivePrincipalMarket", IsNullable = false)]
        public ComplexFivePrincipalMarketType[] AIFMPrincipalMarkets {get; set;}

        [XmlArrayItem("AIFMPrincipalInstrument", IsNullable = false)]
        public ComplexPrincipalInstrumentType[] AIFMPrincipalInstruments {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInEuro {get; set;}

        public ComplexBaseCurrencyDescriptionType AIFMBaseCurrencyDescription {get; set;}
    }
}
