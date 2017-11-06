namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAIFLeverageInfo
    {
        [XmlElement("AIFLeverageArticle24-2")]
        public ComplexAIFLeverageArticle242 AIFLeverageArticle242 {get; set;}

        [XmlArray("AIFLeverageArticle24-4")]
        [XmlArrayItem("BorrowingSource", IsNullable = false)]
        public ComplexBorrowingSource[] AIFLeverageArticle244 {get; set;}
    }
}
