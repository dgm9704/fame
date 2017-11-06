namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexNAVGeographicalFocus
    {

        public decimal AfricaNAVRate {get; set;}

        public decimal AsiaPacificNAVRate {get; set;}

        public decimal EuropeNAVRate {get; set;}

        public decimal EEANAVRate {get; set;}

        public decimal MiddleEastNAVRate {get; set;}

        public decimal NorthAmericaNAVRate {get; set;}

        public decimal SouthAmericaNAVRate {get; set;}

        public decimal SupraNationalNAVRate {get; set;}
    }
}
