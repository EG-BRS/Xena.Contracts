namespace Xena.Contracts.ApiRoutes
{
    public class BookkeepingRoutes : BaseRoutes
    {
        /// <summary>"TransferVoucherPreviewToOrder"</summary>
        public const string PostTransferVoucherPreviewToOrder = "TransferVoucherPreviewToOrder";

        /// <summary>"{orderId}/SettleUnpaidStock"</summary>
        public const string PutSettleUnpaidStock = "{orderId}/SettleUnpaidStock";

        /// <summary>"Api/Fiscal/{fiscalId}/Bookkeeping"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/Bookkeeping";

        /// <summary>"VoucherModifiedHistory"</summary>
        public const string GetVoucherModifiedHistoryList = "VoucherModifiedHistory";

        /// <summary>"DocumentParsedCount"</summary>
        public const string GetDocumentParsedCount = "DocumentParsedCount";

        /// <summary>"UnpaidStockDetails"</summary>
        public const string GetUnpaidStockDetailsList = "UnpaidStockDetails";
    }
}