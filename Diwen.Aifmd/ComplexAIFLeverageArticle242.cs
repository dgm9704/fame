namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    [XmlType(TypeName = "ComplexAIFLeverageArticle24-2Type")]
    public partial class ComplexAIFLeverageArticle242
    {
        public bool AllCounterpartyCollateralRehypothecationFlag {get; set;}

        public decimal AllCounterpartyCollateralRehypothecatedRate {get; set;}

        [XmlIgnore]
        public bool AllCounterpartyCollateralRehypothecatedRateSpecified {get; set;}

        public ComplexSecuritiesCashBorrowing SecuritiesCashBorrowing {get; set;}

        public ComplexFinancialInstrumentBorrowing FinancialInstrumentBorrowing {get; set;}

        [XmlElement(DataType = "integer")]
        public string ShortPositionBorrowedSecuritiesValue {get; set;}

        [XmlArrayItem("ControlledStructure", IsNullable = false)]
        public ComplexControlledStructure[] ControlledStructures {get; set;}

        public ComplexLeverageAIF LeverageAIF {get; set;}
    }
}
