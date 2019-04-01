namespace Xena.Contracts.ApiRoutes
{
    public class PublicRoutes
    {
        /// <summary>"Public"</summary>
        public const string Base = "Public";

        /// <summary>"Terms"</summary>
        public const string GetActiveTerms = "Terms";

        /// <summary>"App/{id}"</summary>
        public const string GetXenaApp = "App/{id}";

        /// <summary>"App"</summary>
        public const string GetXenaAppList = "App";

        /// <summary>"App/Category"</summary>
        public const string GetXenaAppCategoryList = "App/Category";

        /// <summary>"Supporter"</summary>
        public const string GetSupporter = "Supporter";

        //TODO: Should be changed in the Dibs return URL
        /// <summary>"CreateDibsTicket"</summary>
        public const string PostDibsTicket = "CreateDibsTicket";
        /// <summary>"~/Public/Fiscal/{id}/VCard"</summary>
        public const string GetVCardByFiscal = "~/Public/Fiscal/{id}/VCard";

        /// <summary>"~/Public/Fiscal/{id}/Resource/VCard"</summary>
        public const string GetResourceVCardByFiscal = "~/Public/Fiscal/{id}/Resource/VCard";

        /// <summary>"~/Public/User/{id}/VCard"</summary>
        public const string GetVCardByUser = "~/Public/User/{id}/VCard";

        /// <summary>"~/Public/AccountantResource/{id}/VCard"</summary>
        public const string GetVCardByAccountantResource = "~/Public/AccountantResource/{id}/VCard";

        //TODO: Should be changed in the Dibs return URL
        /// <summary>"SendXenaReceiptAsEmail"</summary>
        public const string PostXenaReceiptEmail = "SendXenaReceiptAsEmail";

        /// <summary>"GetTestCallback"</summary>
        public const string GetTestCallback = "GetTestCallback";

        /// <summary>"XenaAppForDiscountCodeList"</summary>
        public const string GetXenaAppForDiscountCodeList = "XenaAppForDiscountCodeList";



    }
}