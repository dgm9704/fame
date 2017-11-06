namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexFinancialInstrumentBorrowing
    {
        [XmlElement(DataType = "integer")]
        public string ExchangedTradedDerivativesExposureValue {get; set;}

        [XmlElement(DataType = "integer")]
        public string OTCDerivativesAmount {get; set;}
    }
}
