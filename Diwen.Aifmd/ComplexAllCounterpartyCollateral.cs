namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAllCounterpartyCollateral
    {

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralCash {get; set;}

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralSecurities {get; set;}

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyOtherCollateralPosted {get; set;}
    }
}
