namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexBaseCurrencyDescriptionType
    {

        public string BaseCurrency {get; set;}

        [XmlElement(DataType = "integer")]
        public string AUMAmountInBaseCurrency {get; set;}

        public FXEURReferenceRateTypeType FXEURReferenceRateType {get; set;}

        [XmlIgnore]
        public bool FXEURReferenceRateTypeSpecified {get; set;}

        public decimal FXEURRate {get; set;}

        [XmlIgnore]
        public bool FXEURRateSpecified {get; set;}

        public string FXEUROtherReferenceRateDescription {get; set;}
    }
}
