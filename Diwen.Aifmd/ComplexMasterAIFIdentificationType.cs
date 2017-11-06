namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexMasterAIFIdentificationType
    {
        public string AIFName {get; set;}

        public ComplexAIFNationalIdentifierType AIFIdentifierNCA {get; set;}
    }
}
