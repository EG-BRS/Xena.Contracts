namespace Xena.Contracts.ApiRoutes
{
    public class BankPostingReconciliationSuggestionRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/BankPosting"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/BankPostingReconciliationSuggestion";

        /// <summary>"~/Api/Fiscal/{fiscalId}/BankPosting/{id}/RecreateSuggestions"</summary>
        public const string PutRecreateSuggestions = "~/Api/Fiscal/{fiscalId}/BankPosting/{id}/RecreateSuggestions";

        /// <summary>"Execute"</summary>
        public const string PutExecute = "Execute";

        /// <summary>"~/Api/Fiscal/{fiscalId}/BankPosting/{id}/ReconciliationSuggestion"</summary>
        public const string GetReconciliationSuggestionsForBankPostingList = "~/Api/Fiscal/{fiscalId}/BankPosting/{id}/ReconciliationSuggestion";

        /// <summary>"~/Api/Fiscal/{fiscalId}/LedgerPost/{id}/ReconciliationSuggestion"</summary>
        public const string GetReconciliationSuggestionsForLedgerPostList = "~/Api/Fiscal/{fiscalId}/LedgerPost/{id}/ReconciliationSuggestion";
    }
}