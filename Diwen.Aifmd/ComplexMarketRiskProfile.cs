namespace Diwen.Aifmd
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexMarketRiskProfile
    {

        public string AnnualInvestmentReturnRate {get; set;}

        [XmlArrayItem("MarketRiskMeasure", IsNullable = false)]
        public ComplexMarketRiskMeasure[] MarketRiskMeasures {get; set;}
    }
}
