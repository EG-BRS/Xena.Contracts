namespace Xena.Contracts.ApiRoutes
{
    public class BankPostingReconciliationSuggestionRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/BankPosting"</summary>
        public const string Base = "Fiscal/{fiscalId}/BankPostingReconciliationSuggestion";

        /// <summary>"~/Fiscal/{fiscalId}/BankPosting/{id}/RecreateSuggestions"</summary>
        public const string PutRecreateSuggestions = "~/Fiscal/{fiscalId}/BankPosting/{id}/RecreateSuggestions";

        /// <summary>"Execute"</summary>
        public const string PutExecute = "Execute";

        /// <summary>"~/Fiscal/{fiscalId}/BankPosting/{id}/ReconciliationSuggestion"</summary>
        public const string GetReconciliationSuggestionsForBankPostingList = "~/Fiscal/{fiscalId}/BankPosting/{id}/ReconciliationSuggestion";

        /// <summary>"~/Fiscal/{fiscalId}/LedgerPost/{id}/ReconciliationSuggestion"</summary>
        public const string GetReconciliationSuggestionsForLedgerPostList = "~/Fiscal/{fiscalId}/LedgerPost/{id}/ReconciliationSuggestion";
    }
}