namespace Xena.Contracts.ApiRoutes
{
    public class PartnerDeliveryAddressRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PartnerDeliveryAddress"</summary>
        public const string Base = "Fiscal/{fiscalId}/PartnerDeliveryAddress";

        /// <summary>"~/Fiscal/{fiscalId}/Partner/{id}/DeliveryAddress"</summary>
        public const string GetByPartnerList = "~/Fiscal/{fiscalId}/Partner/{id}/DeliveryAddress";

        /// <summary>"{id}/SetDefault"</summary>
        public const string PutSetDefault = "{id}/SetDefault";

        /// <summary>"{id}/RemoveAsDefault"</summary>
        public const string PutRemoveAsDefault = "{id}/RemoveAsDefault";


    }
}