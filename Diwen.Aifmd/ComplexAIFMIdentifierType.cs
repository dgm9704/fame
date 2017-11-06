namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFMIdentifierType
    {

        public string AIFMIdentifierLEI {get; set;}

        public string AIFMIdentifierBIC {get; set;}

        public ComplexAIFMNationalIdentifierType OldAIFMIdentifierNCA {get; set;}
    }
}
