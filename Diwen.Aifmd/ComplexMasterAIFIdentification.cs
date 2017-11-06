namespace Diwen.Aifmd
{
    using System;
    [Serializable]
    public partial class ComplexMasterAIFIdentification
    {
        public string AIFName {get; set;}

        public ComplexAIFNationalIdentifier AIFIdentifierNCA {get; set;}
    }
}
