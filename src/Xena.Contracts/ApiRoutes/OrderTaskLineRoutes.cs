namespace Xena.Contracts.ApiRoutes
{
    public class OrderTaskLineRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/OrderTaskLine"</summary>
        public const string Base = "Fiscal/{fiscalId}/OrderTaskLine";

        /// <summary>"~/Fiscal/{fiscalId}/FiscalPeriod/{id}/Line"</summary>
        public const string GetByFiscalPeriod = "~/Fiscal/{fiscalId}/FiscalPeriod/{fiscalPeriodId}/OrderTaskLine";

        /// <summary>"~/Fiscal/{fiscalId}/PartnerResourceContext/OrderTaskLine"</summary>
        public const string GetByApprover = "~/Fiscal/{fiscalId}/PartnerResourceContext/OrderTaskLine";

        /// <summary>"Current"</summary>
        public const string GetByResource = "Current";

        /// <summary>"~/Fiscal/{fiscalId}/OrderTask/{orderId}/Line"</summary>
        public const string GetByOrder = "~/Fiscal/{fiscalId}/Order/{orderId}/Line";

        /// <summary>"~/Fiscal/{fiscalId}/OrderTask/{orderTaskId}/Line"</summary>
        public const string GetByOrderTask = "~/Fiscal/{fiscalId}/OrderTask/{orderTaskId}/Line";

        /// <summary>"Bookkeep"</summary>
        public const string PutBookkeep = "Bookkeep";

        /// <summary>"OrderTaskLineType"</summary>
        public const string GetOrderTaskLineTypeList = "OrderTaskLineType";
    }
}