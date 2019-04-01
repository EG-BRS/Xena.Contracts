namespace Xena.Contracts.ApiRoutes
{
    public class OrderLineRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderLine"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderLine";

        /// <summary>"~/Fiscal/{fiscalId}/OrderTask/{id}/OrderLine"</summary>
        public const string GetByOrderTask = "~/Fiscal/{fiscalId}/OrderTask/{id}/OrderLine";

        /// <summary>"Old/{id}"</summary>
        public const string ObsoleteGet = "Old/{id}";

        /// <summary>"Old/{id}"</summary>
        public const string ObsoletePut = "Old/{id}";

        /// <summary>"Old/{id}"</summary>
        public const string ObsoleteDelete = "Old/{id}";

        /// <summary>"Old"</summary>
        public const string ObsoletePost = "Old";

        ///<summary>"BulkCreateOrderLine"</summary>
        public const string PostBulkCreateOrderLine = "Bulk";

        public const string GetLinkedLines = "{id}/LinkedLines";
    }
}