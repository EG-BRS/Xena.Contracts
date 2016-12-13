namespace Xena.Contracts
{
    public static class LedgerBookkeepingStatus
    {
        public const string Bookkeeping_Started = "LedgerBookkeepingStatus_Started";
        public const string Bookkeeping_Saving_Transaction = "LedgerBookkeepingStatus_Saving_Transaction";
        public const string Bookkeeping_Transactions_Created = "LedgerBookkeepingStatus_Transactions_Created";
        public const string Bookkeeping_Transactions_Validated = "LedgerBookkeepingStatus_Transactions_Validated";
        public const string Bookkeeping_Transactions_Validation_Failed = "LedgerBookkeepingStatus_Transactions_Validation_Failed";
        public const string Bookkeeping_Cancelled = "LedgerBookkeepingStatus_Cancelled";
        public const string Bookkeeping_History_Inserted = "LedgerBookkeepingStatus_History_Inserted";
        public const string Bookkeeping_BankReconciliation_Inserted = "LedgerBookkeepingStatus_BankReconciliation_Inserted";
        public const string Bookkeeping_Documents_Moved_To_Vouchers = "LedgerBookkeepingStatus_Documents_Moved_To_Vouchers";
        public const string Bookkeeping_Completed = "LedgerBookkeepingStatus_Completed";
        public const string Bookkeeping_Saving_Settlements = "LedgerBookkeepingStatus_Saving_Settlements";
    }
}