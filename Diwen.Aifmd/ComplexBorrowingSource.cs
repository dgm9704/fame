namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexBorrowingSourceType
    {
        public FiveRankingType Ranking {get; set;}

        public bool BorrowingSourceFlag {get; set;}

        public ComplexEntityIdentificationType SourceIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string LeverageAmount {get; set;}
    }
}
