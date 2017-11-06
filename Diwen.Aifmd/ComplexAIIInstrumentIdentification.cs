namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIIInstrumentIdentification
    {

        public string AIIExchangeCode {get; set;}

        public string AIIProductCode {get; set;}

        public AIIDerivativeType AIIDerivativeType {get; set;}

        public AIIPutCallIdentifier AIIPutCallIdentifier {get; set;}

        [XmlElement(DataType = "date")]
        public DateTime AIIExpiryDate {get; set;}

        public decimal AIIStrikePrice {get; set;}
    }
}
