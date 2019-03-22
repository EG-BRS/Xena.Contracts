namespace Xena.Contracts.ApiRoutes
{
    public class BankPostingRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/BankPosting"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/BankPosting";

        /// <summary>"~/Api/Fiscal/{fiscalId}/LedgerTagBankContext/{id}/Posting"</summary>
        public const string GetByBankContextList = BaseFiscalUri + "LedgerTagBankContext/{id}/Posting";

        /// <summary>"~/Api/Fiscal/{fiscalId}/LedgerTagBankContext/{id}/UnReconciledPosting"</summary>
        public const string DeleteUnReconciledPost = BaseFiscalUri + "LedgerTagBankContext/{id}/UnReconciledPosting";

        /// <summary>"~/Api/Fiscal/{fiscalId}/LedgerTagBankContext/{id}/UnReconciledPosting"</summary>
        public const string PutUnReconciledPostToLedger = BaseFiscalUri + "LedgerTagBankContext/{id}/UnReconciledPosting";

        /// <summary>"Reconciliate"</summary>
        public const string PostReconciliate = "Reconciliate";

        /// <summary>"ReconciliationSummary"</summary>
        public const string GetReconciliationSummary = "ReconciliationSummary";

        /// <summary>"InvolvedBankPostings"</summary>
        public const string GetInvolvedBankPostings = "InvolvedBankPostings";


    }
}