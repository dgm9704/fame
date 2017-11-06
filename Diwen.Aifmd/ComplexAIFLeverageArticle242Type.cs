namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    [XmlType(TypeName = "ComplexAIFLeverageArticle24-2Type")]
    public partial class ComplexAIFLeverageArticle242Type
    {
        public bool AllCounterpartyCollateralRehypothecationFlag {get; set;}

        public decimal AllCounterpartyCollateralRehypothecatedRate {get; set;}

        [XmlIgnore]
        public bool AllCounterpartyCollateralRehypothecatedRateSpecified {get; set;}

        public ComplexSecuritiesCashBorrowingType SecuritiesCashBorrowing {get; set;}

        public ComplexFinancialInstrumentBorrowingType FinancialInstrumentBorrowing {get; set;}

        [XmlElement(DataType = "integer")]
        public string ShortPositionBorrowedSecuritiesValue {get; set;}

        [XmlArrayItem("ControlledStructure", IsNullable = false)]
        public ComplexControlledStructureType[] ControlledStructures {get; set;}

        public ComplexLeverageAIFType LeverageAIF {get; set;}
    }
}
