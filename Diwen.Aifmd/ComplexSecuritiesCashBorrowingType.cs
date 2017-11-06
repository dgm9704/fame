namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexSecuritiesCashBorrowingType
    {
        [XmlElement(DataType = "integer")]
        public string UnsecuredBorrowingAmount {get; set;}

        [XmlElement(DataType = "integer")]
        public string SecuredBorrowingPrimeBrokerageAmount {get; set;}

        [XmlElement(DataType = "integer")]
        public string SecuredBorrowingReverseRepoAmount {get; set;}

        [XmlElement(DataType = "integer")]
        public string SecuredBorrowingOtherAmount {get; set;}
    }
}
