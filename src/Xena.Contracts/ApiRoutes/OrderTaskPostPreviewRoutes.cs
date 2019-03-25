namespace Xena.Contracts.ApiRoutes
{
    public class OrderTaskPostPreviewRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderTaskPostPreview"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderTaskPostPreview";

        /// <summary>"~/Fiscal/{fiscalId}/VoucherPreview/{id}/OrderTaskPostPreview"</summary>
        public const string GetByVoucherPreviewList = "~/Fiscal/{fiscalId}/VoucherPreview/{id}/OrderTaskPostPreview";
    }
}