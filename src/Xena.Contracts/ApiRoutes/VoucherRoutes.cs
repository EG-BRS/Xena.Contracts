namespace Xena.Contracts.ApiRoutes
{
    public class VoucherRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Voucher"</summary>
        public const string Base = "Fiscal/{fiscalId}/Voucher";

        /// <summary>""History""</summary>
        public const string GetHistoryList = "History";

        /// <summary>"{id}/Summary"</summary>
        public const string GetSummary = "{id}/Summary";

        /// <summary>"{id}/Transaction"</summary>
        public const string GetTransactionsByVoucher = "{id}/Transaction";
    }
}