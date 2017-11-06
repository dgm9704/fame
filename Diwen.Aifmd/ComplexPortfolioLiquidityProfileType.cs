namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexPortfolioLiquidityProfileType
    {

        public decimal PortfolioLiquidityInDays0to1Rate { get; set; }

        public decimal PortfolioLiquidityInDays2to7Rate { get; set; }

        public decimal PortfolioLiquidityInDays8to30Rate { get; set; }

        public decimal PortfolioLiquidityInDays31to90Rate { get; set; }

        public decimal PortfolioLiquidityInDays91to180Rate { get; set; }

        public decimal PortfolioLiquidityInDays181to365Rate { get; set; }

        public decimal PortfolioLiquidityInDays365MoreRate { get; set; }

        [XmlElement(DataType = "integer")]
        public string UnencumberedCash { get; set; }
    }
}
