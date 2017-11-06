namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexAssumption
    {

        [XmlElement(DataType = "integer")]
        public string QuestionNumber {get; set;}

        public string AssumptionDescription {get; set;}
    }
}
