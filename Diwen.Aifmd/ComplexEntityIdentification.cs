namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexEntityIdentification
    {
        public string EntityName {get; set;}

        public string EntityIdentificationBIC {get; set;}

        public string EntityIdentificationLEI {get; set;}
    }
}
