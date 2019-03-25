namespace Xena.Contracts.ApiRoutes
{
    public class LocationRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Location"</summary>
        public const string Base = "Fiscal/{fiscalId}/Location";

        /// <summary>"{locationToDeactivateId}/MergeInto/{locationToKeepId}"</summary>
        public const string DeleteMergeInto = "{locationToDeactivateId}/MergeInto/{locationToKeepId}";

        /// <summary>"LocationType"</summary>
        public const string GetLocationTypeList = "LocationType";

    }
}