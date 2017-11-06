namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public enum FiveRankingType
    {

        [XmlEnum("1")]
        Item1,

        [XmlEnum("2")]
        Item2,

        [XmlEnum("3")]
        Item3,

        [XmlEnum("4")]
        Item4,

        [XmlEnum("5")]
        Item5,
    }
}
