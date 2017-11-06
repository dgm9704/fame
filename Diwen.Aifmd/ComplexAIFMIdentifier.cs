namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexAIFMIdentifier
    {

        public string AIFMIdentifierLEI {get; set;}

        public string AIFMIdentifierBIC {get; set;}

        public ComplexAIFMNationalIdentifier OldAIFMIdentifierNCA {get; set;}
    }
}
