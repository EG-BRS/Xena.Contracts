namespace Xena.Contracts.ApiRoutes
{
    public class VatSettlementRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/VatSettlement"</summary>
        public const string Base = "Fiscal/{fiscalId}/VatSettlement";

        /// <summary>"{id}/Pay"</summary>
        public const string PostPayVatsettlement = "{id}/Pay";

        /// <summary>"SettleVatPeriod"</summary>
        public const string PostSettleVatPeriod = "SettleVatPeriod";

        /// <summary>"VatSettlementPost"</summary>
        public const string GetVatSettlementPosts = "VatSettlementPost";

        /// <summary>"VatSettlementData"</summary>
        public const string GetVatSettlementData = "VatSettlementData";

        /// <summary>"VatSettlementSummary"</summary>
        public const string GetVatSettlementSummary = "VatSettlementSummary";
    }
}