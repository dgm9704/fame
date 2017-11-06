namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFLeverageInfoType
    {
        [XmlElement("AIFLeverageArticle24-2")]
        public ComplexAIFLeverageArticle242Type AIFLeverageArticle242 {get; set;}

        [XmlArray("AIFLeverageArticle24-4")]
        [XmlArrayItem("BorrowingSource", IsNullable = false)]
        public ComplexBorrowingSourceType[] AIFLeverageArticle244 {get; set;}
    }
}
