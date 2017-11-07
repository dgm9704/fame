namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;

    [Serializable]
    [XmlType(AnonymousType = true)]
    [XmlRoot(Namespace = "", IsNullable = false)]
    public partial class AIFMReportingInfo
    {

        [XmlElement("AIFMRecordInfo", typeof(ComplexAIFMRecordInfo))]
        [XmlElement("CancellationAIFMRecordInfo", typeof(ComplexCancellationAIFMRecordInfo))]
        public object[] Items { get; set; }

        [XmlAttribute]
        public string ReportingMemberState { get; set; }

        [XmlAttribute]
        public string Version { get; set; }

        [XmlAttribute]
        public DateTime CreationDateAndTime { get; set; }
    }
}
