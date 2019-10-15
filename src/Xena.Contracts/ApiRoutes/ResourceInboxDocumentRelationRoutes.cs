namespace Xena.Contracts.ApiRoutes
{
    public class ResourceInboxDocumentRelationRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/ResourceInboxDocumentRelation"</summary>
        public const string Base = "Fiscal/{fiscalId}/ResourceInboxDocumentRelation";

        /// <summary>"ByResource"</summary>
        public const string GetByResource = "ByResource";

        /// <summary>"GetResourceInbox"</summary>
        public const string GetResourceInbox = "GetResourceInbox";

        /// <summary>"{id}/MarkRead"</summary>
        public const string PutMarkRead = "{id}/MarkRead";
    }
}