namespace Xena.Contracts.ApiRoutes
{
    public class LedgerTagRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/LedgerTag"</summary>
        public const string Base = "Fiscal/{fiscalId}/LedgerTag";

        /// <summary>"SettlementTag"</summary>
        public const string GetSettlementTag = "SettlementTag";

        /// <summary>"CurrencyDifferenceTag"</summary>
        public const string GetCurrencyDifferenceTagList = "CurrencyDifferenceTag";

        /// <summary>"LedgerAccount"</summary>
        public const string GetLedgerAccountList = "LedgerAccount";

        /// <summary>"History"</summary>
        public const string GetHistory = "History";

        /// <summary>"LedgerTagSuggestion"</summary>
        public const string GetSuggestion = "Suggestion";

        /// <summary>"LedgerAccountInfo"</summary>
        public const string GetLedgerAccountInfoList = "LedgerAccountInfo";

        /// <summary>"LedgerGroup"</summary>
        public const string GetLedgerGroupList = "LedgerGroup";

        /// <summary>"LedgerAccounts/ArticleGroup"</summary>
        public const string GetLedgerAccountsAllowingArticleGroupList = "LedgerAccounts/ArticleGroup";

        /// <summary>"LedgerAccounts/LedgerTag"</summary>
        public const string GetLedgerAccountsAllowingLedgerTagList = "LedgerAccounts/LedgerTag";

        /// <summary>"LedgerTagAccount"</summary>
        public const string GetLedgerTagAccount = "LedgerTagAccount";

        /// <summary>"LedgerTagType"</summary>
        public const string GetLedgerTagTypeList = "LedgerTagType";

        /// <summary>"DefaultCurrencyDifferenceTag"</summary>
        public const string PostDefaultCurrencyDifferenceTag = "DefaultCurrencyDifferenceTag";

        /// <summary>"{id}/DuplicateAccountNumbers"</summary>
        public const string GetDuplicateAccountNumbers = "{id}/DuplicateAccountNumbers";

        /// <summary>"DuplicateAccountNumber"</summary>
        public const string GetDuplicateAccountNumberByNumbers = "DuplicateAccountNumber";

        /// <summary>"{ledgerAccount}/DuplicateAccountNumberInLedgerAccount"</summary>
        public const string GetDuplicateAccountNumberByLedgerAccount = "{ledgerAccount}/DuplicateAccountNumberInLedgerAccount";
    }
}