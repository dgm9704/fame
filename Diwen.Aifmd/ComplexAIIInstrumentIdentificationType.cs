namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIIInstrumentIdentificationType
    {

        public string AIIExchangeCode { get; set; }

        public string AIIProductCode { get; set; }

        public AIIDerivativeTypeType AIIDerivativeType { get; set; }

        public AIIPutCallIdentifierType AIIPutCallIdentifier { get; set; }

        [XmlElement(DataType = "date")]
        public DateTime AIIExpiryDate { get; set; }

        public decimal AIIStrikePrice { get; set; }
    }
}
