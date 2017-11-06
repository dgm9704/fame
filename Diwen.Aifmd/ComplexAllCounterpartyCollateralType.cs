namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAllCounterpartyCollateralType
    {

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralCash { get; set; }

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyCollateralSecurities { get; set; }

        [XmlElement(DataType = "integer")]
        public string AllCounterpartyOtherCollateralPosted { get; set; }
    }
}
