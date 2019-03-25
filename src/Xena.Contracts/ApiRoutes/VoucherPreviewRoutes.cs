namespace Xena.Contracts.ApiRoutes
{
    public class VoucherPreviewRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/VoucherPreview "</summary>
        public const string Base = "Fiscal/{fiscalId}/VoucherPreview";

        /// <summary>"~/Fiscal/{fiscalId}/ResourceInbox/{id}/VoucherPreview"</summary>
        public const string GetVoucherPreviewForResourceInbox = "~/Fiscal/{fiscalId}/ResourceInbox/{id}/VoucherPreview";

        /// <summary>"~/Fiscal/{fiscalId}/ResourceInbox/{id}/VoucherPreview"</summary>
        public const string PostFromResourceInbox = "~/Fiscal/{fiscalId}/ResourceInbox/{id}/VoucherPreview";

        /// <summary>"{id}/Summary"</summary>
        public const string GetSummary = "{id}/Summary";

        /// <summary>"{id}/Bookkeep"</summary>
        public const string PutBookkeep = "{id}/Bookkeep";

        /// <summary>"{id}/PartnerSuggestion"</summary>
        public const string GetPartnerSuggestion = "{id}/PartnerSuggestion";
    }
}