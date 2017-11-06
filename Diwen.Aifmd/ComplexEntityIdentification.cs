namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexEntityIdentificationType
    {
        public string EntityName {get; set;}

        public string EntityIdentificationBIC {get; set;}

        public string EntityIdentificationLEI {get; set;}
    }
}
