namespace Xena.Contracts.ApiRoutes.DocumentRelated
{
    public class DocumentRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Document"</summary>
        public const string Base = "Fiscal/{fiscalId}/Document";

        /// <summary>"Fiscal/{fiscalId}/Document/DocumentVersion"</summary>
        public const string BaseDocumentVersion = Base + "/DocumentVersion";

        /// <summary>"Fiscal/{fiscalId}/Document/{id}/Relation/{relationType}/{relationId}"</summary>
        public const string RelationBase = Base + "/{id}/Relation/{relationType}/{relationId}";

        /// <summary>"{id}/Rotate"</summary>
        public const string PutRotate = "{id}/Rotate";

        /// <summary>"~/Fiscal/{fiscalId}/{type}/{parentId}/Document"</summary>
        public const string GetByTypeList = "~/Fiscal/{fiscalId}/{type}/{parentId}/Document";

        /// <summary>"~/Fiscal/{fiscalId}/{type}/{parentId}/DocumentCount"</summary>
        public const string GetDocumentCount = "~/Fiscal/{fiscalId}/{type}/{parentId}/DocumentCount";

        /// <summary>"Partner/{id}/Shared"</summary>
        public const string GetSharedFromPartner = "Partner/{id}/Shared";

        /// <summary>"Inbox"</summary>
        public const string GetInbox = "Inbox";

        /// <summary>"ResourceInboxRelations"</summary>
        public const string GetRelationsForInbox = "ResourceInboxRelations";

        /// <summary>"~/Fiscal/{fiscalId}/Document/{id}/Relation/{relationType}/{relationId}"</summary>
        public const string PostRelation = "~/" + RelationBase;

        /// <summary>"{id}/VersionFromXenaDocument/{parentId}"</summary>
        public const string PostVersionFromXenaDocument = "{id}/VersionFromXenaDocument/{parentId}";

        /// <summary>"~/Fiscal/{fiscalId}/Document/{id}/Relation/{relationType}/{relationId}"</summary>
        public const string DeleteRelation = "~/" + RelationBase;

        /// <summary>"{id}/Relation"</summary> 
        public const string GetRelationList = "{id}/Relation";

        /// <summary>"History"</summary>
        public const string GetHistoryList = "History";

        /// <summary>"Document/{id}/LastVersion"</summary>
        public const string GetLastVersionForDocument = "Document/{id}/LastVersion";

        /// <summary>"DocumentVersion/{id}"</summary>
        public const string GetDocumentVersion = "DocumentVersion/{id}";

        /// <summary>"{id}/Version"</summary>
        public const string GetVersionList = "{id}/Version";

        /// <summary>"Version/{id}/Note"</summary>
        public const string PutVersionNote = "Version/{id}/Note";

        /// <summary>"{id}/NameAndDescription"</summary>
        public const string PutNameAndDescription = "{id}/NameAndDescription";

        /// <summary>"Relation/{id}/Resource/{resourceId}"</summary>
        public const string PostMoveInboxRelationToOtherResource = "Relation/{id}/Resource/{resourceId}";

        /// <summary>"Document/{id}/Resource/{resourceContextId}"</summary>
        public const string PostMoveDocumentToOtherResourceInbox = "Document/{id}/Resource/{resourceContextId}";

        /// <summary>"FiscalSetup/{id}/Shared"</summary>
        public const string GetSharedFromFiscal = "FiscalSetup/{id}/Shared";

        /// <summary>"DocumentFolderConfiguration"</summary>
        public const string GetDocumentFolderConfiguration = "DocumentFolderConfiguration";
    }
}