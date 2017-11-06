namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMarketRiskProfileType
    {

        public string AnnualInvestmentReturnRate { get; set; }

        [XmlArrayItem("MarketRiskMeasure", IsNullable = false)]
        public ComplexMarketRiskMeasureType[] MarketRiskMeasures { get; set; }
    }
}
