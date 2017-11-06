namespace Schemas
{
    using System;
    using System.Xml.Serialization;
    [Serializable]
    public partial class ComplexIndividualExposureType
    {

        [XmlArrayItem("AssetTypeExposure", IsNullable = false)]
        public ComplexAssetTypeExposureType[] AssetTypeExposures { get; set; }

        [XmlArrayItem("AssetTypeTurnover", IsNullable = false)]
        public ComplexAssetTypeTurnoverType[] AssetTypeTurnovers { get; set; }

        [XmlArrayItem("CurrencyExposure", IsNullable = false)]
        public ComplexCurrencyExposureType[] CurrencyExposures { get; set; }

        [XmlArrayItem("CompanyDominantInfluence", IsNullable = false)]
        public ComplexCompanyDominantInfluenceType[] CompaniesDominantInfluence { get; set; }
    }
}
