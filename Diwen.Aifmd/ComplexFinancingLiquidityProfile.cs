namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexFinancingLiquidityProfile
    {

        [XmlElement(DataType = "integer")]
        public string TotalFinancingAmount {get; set;}

        public decimal TotalFinancingInDays0to1Rate {get; set;}

        public decimal TotalFinancingInDays2to7Rate {get; set;}

        public decimal TotalFinancingInDays8to30Rate {get; set;}

        public decimal TotalFinancingInDays31to90Rate {get; set;}

        public decimal TotalFinancingInDays91to180Rate {get; set;}

        public decimal TotalFinancingInDays181to365Rate {get; set;}

        public decimal TotalFinancingInDays365MoreRate {get; set;}
    }
}
