namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexIndividualExposure
    {

        [XmlArrayItem("AssetTypeExposure", IsNullable = false)]
        public ComplexAssetTypeExposure[] AssetTypeExposures {get; set;}

        [XmlArrayItem("AssetTypeTurnover", IsNullable = false)]
        public ComplexAssetTypeTurnover[] AssetTypeTurnovers {get; set;}

        [XmlArrayItem("CurrencyExposure", IsNullable = false)]
        public ComplexCurrencyExposure[] CurrencyExposures {get; set;}

        [XmlArrayItem("CompanyDominantInfluence", IsNullable = false)]
        public ComplexCompanyDominantInfluence[] CompaniesDominantInfluence {get; set;}
    }
}
