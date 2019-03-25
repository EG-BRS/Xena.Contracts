namespace Xena.Contracts.ApiRoutes
{
    public class OrderTaskPostRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderTaskPost"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderTaskPost";

        /// <summary>"FilteredList"</summary>
        public const string GetFilteredList = "FilteredList";

        /// <summary>"~/Fiscal/{fiscalId}/OrderTask/{id}/Post"</summary>
        public const string GetByOrderTask = "~/Fiscal/{fiscalId}/OrderTask/{id}/Post";

        /// <summary>"~/Fiscal/{fiscalId}/OrderLine/{id}/Post"</summary>
        public const string GetByOrderLine = "~/Fiscal/{fiscalId}/OrderLine/{id}/Post";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/Post"</summary>
        public const string GetByOrder = "~/Fiscal/{fiscalId}/Order/{id}/Post";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/Post/Grouped"</summary>
        public const string GetByOrderGrouped = "~/Fiscal/{fiscalId}/Order/{id}/Post/Grouped";

        /// <summary>"~/Fiscal/{fiscalId}/Project/{id}/Post"</summary>
        public const string GetByProject = "~/Fiscal/{fiscalId}/Project/{id}/Post";

        /// <summary>"~/Fiscal/{fiscalId}/Order/{id}/TransferCostToLines"</summary>
        public const string PutCreateOrderLines = "~/Fiscal/{fiscalId}/Order/{id}/TransferCostToLines";
        /// <summary>"Move"</summary>
        public const string PutMove = "Move";
    }
}