namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public enum AIFMContentTypeType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,
    }
}
