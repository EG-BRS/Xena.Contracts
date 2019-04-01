namespace Xena.Contracts.ApiRoutes
{
    public class PriceDiscountAgreementRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PriceDiscountAgreement"</summary>
        public const string Base = "Fiscal/{fiscalId}/PriceDiscountAgreement";
        /// <summary>"~/Fiscal/{fiscalId}/ArticleGroup/{id}/PriceDiscountAgreement"</summary>
        public const string GetByArticleGroupList = "~/Fiscal/{fiscalId}/ArticleGroup/{id}/PriceDiscountAgreement";
        /// <summary>"~/Fiscal/{fiscalId}/Article/{id}/PriceDiscountAgreement"</summary>
        public const string GetByArticleList = "~/Fiscal/{fiscalId}/Article/{id}/PriceDiscountAgreement";
        /// <summary>"~/Fiscal/{fiscalId}/PriceGroup/{id}/PriceDiscountAgreement"</summary>
        public const string GetByPriceGroupList = "~/Fiscal/{fiscalId}/PriceGroup/{id}/PriceDiscountAgreement";
        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/PriceDiscountAgreement"</summary>
        public const string GetByPartnerList = "~/Fiscal/{fiscalId}/Partner/{id}/PriceDiscountAgreement";

    }
}