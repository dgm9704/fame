namespace Schemas
{
    using System;
    [Serializable]
    public partial class ComplexCompanyDominantInfluenceType
    {

        public ComplexEntityIdentificationType CompanyIdentification { get; set; }

        public TransactionTypeType TransactionType { get; set; }

        public string OtherTransactionTypeDescription { get; set; }

        public decimal VotingRightsRate { get; set; }
    }
}
