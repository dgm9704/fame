namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AIFMReportingInfo
    {

        [XmlElement("AIFMRecordInfo", typeof(ComplexAIFMRecordInfoType))]
        [XmlElement("CancellationAIFMRecordInfo", typeof(ComplexCancellationAIFMRecordInfoType))]
        public object[] Items {get; set;}

        [XmlAttribute]
        public string ReportingMemberState {get; set;}

        [XmlAttribute]
        public string Version {get; set;}

        [XmlAttribute]
        public DateTime CreationDateAndTime {get; set;}
    }
}
