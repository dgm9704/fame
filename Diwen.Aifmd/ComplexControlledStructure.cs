namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexControlledStructure
    {
        public ComplexEntityIdentification ControlledStructureIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string ControlledStructureExposureValue {get; set;}
    }
}
