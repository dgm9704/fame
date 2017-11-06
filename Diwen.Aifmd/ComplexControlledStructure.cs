namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexControlledStructureType
    {
        public ComplexEntityIdentificationType ControlledStructureIdentification {get; set;}

        [XmlElement(DataType = "integer")]
        public string ControlledStructureExposureValue {get; set;}
    }
}
