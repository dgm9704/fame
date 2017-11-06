namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFMCompleteDescription
    {

        public ComplexAIFMIdentifier AIFMIdentifier {get; set;}

        [XmlArrayItem("AIFMFivePrincipalMarket", IsNullable = false)]
        public ComplexFivePrincipalMarket[] AIFMPrincipalMarkets {get; set;}

        [XmlArrayItem("AIFMPrincipalInstrument", IsNullable = false)]
        public ComplexPrincipalInstrument[] AIFMPrincipalInstruments {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInEuro {get; set;}

        public ComplexBaseCurrencyDescription AIFMBaseCurrencyDescription {get; set;}
    }
}
