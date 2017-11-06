namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexShareClassIdentifierType
    {
        public string ShareClassNationalCode {get; set;}

        public string ShareClassIdentifierISIN {get; set;}

        public string ShareClassIdentifierCUSIP {get; set;}

        public string ShareClassIdentifierSEDOL {get; set;}

        public string ShareClassIdentifierTicker {get; set;}

        public string ShareClassIdentifierRIC {get; set;}

        public string ShareClassName {get; set;}
    }
}
