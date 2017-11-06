namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexAIFIdentifierType
    {
        public string AIFIdentifierLEI {get; set;}

        public string AIFIdentifierISIN {get; set;}

        public string AIFIdentifierCUSIP {get; set;}
        public string AIFIdentifierSEDOL {get; set;}

        public string AIFIdentifierTicker {get; set;}

        public string AIFIdentifierRIC {get; set;}

        public string AIFIdentifierECB {get; set;}

        public ComplexAIFNationalIdentifierType OldAIFIdentifierNCA {get; set;}
    }
}
