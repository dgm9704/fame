namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexBorrowingSource
    {
        public FiveRanking Ranking {get; set;}

        public bool BorrowingSourceFlag {get; set;}

        public ComplexEntityIdentification SourceIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string LeverageAmount {get; set;}
    }
}
