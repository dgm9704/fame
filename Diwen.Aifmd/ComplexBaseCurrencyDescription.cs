namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexBaseCurrencyDescription
    {

        public string BaseCurrency {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInBaseCurrency {get; set;}

        public FXEURReferenceRateType FXEURReferenceRateType {get; set;}

        [XmlIgnore]
        public bool FXEURReferenceRateTypeSpecified {get; set;}

        public decimal FXEURRate {get; set;}

        [XmlIgnore]
        public bool FXEURRateSpecified {get; set;}

        public string FXEUROtherReferenceRateDescription {get; set;}
    }
}
