namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexFinancialInstrumentBorrowingType
    {
        [XmlElement(DataType = "integer")]
        public string ExchangedTradedDerivativesExposureValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string OTCDerivativesAmount {get; set;}
    }
}
