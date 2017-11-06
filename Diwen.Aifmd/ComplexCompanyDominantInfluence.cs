namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexCompanyDominantInfluence
    {

        public ComplexEntityIdentification CompanyIdentification { get; set; }

        public TransactionType TransactionType { get; set; }

        public string OtherTransactionTypeDescription { get; set; }

        public decimal VotingRightsRate { get; set; }
    }
}
