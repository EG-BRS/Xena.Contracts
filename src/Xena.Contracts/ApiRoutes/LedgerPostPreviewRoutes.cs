namespace Xena.Contracts.ApiRoutes
{
    public class LedgerPostPreviewRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/LedgerPostPreview "</summary>
        public const string Base = "Fiscal/{fiscalId}/LedgerPostPreview";

        /// <summary>"~/Fiscal/{fiscalId}/VoucherPreview/{id}/LedgerPostPreview"</summary>
        public const string GetByVoucherPreviewList = "~/Fiscal/{fiscalId}/VoucherPreview/{id}/LedgerPostPreview";

        /// <summary>"~/Fiscal/{fiscalId}/VoucherPreview/{id}/ContraLedgerPostPreview"</summary>
        public const string GetByVoucherContraPreviewList = "~/Fiscal/{fiscalId}/VoucherPreview/{id}/ContraLedgerPostPreview";

        /// <summary>""~/Fiscal/{fiscalId}/VoucherPreview/{id}/DifferenceLedgerPostPreview"</summary>
        public const string GetByVoucherDifferencePreviewList = "~/Fiscal/{fiscalId}/VoucherPreview/{id}/DifferenceLedgerPostPreview";

        /// <summary>"LedgerPostPreviewType"</summary>
        public const string GetLedgerPostPreviewTypeList = "LedgerPostPreviewType";
    }
}