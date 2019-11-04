namespace Xena.Contracts.ApiRoutes
{
    public class TransactionRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Transaction"</summary>
        public const string Base = "Fiscal/{fiscalId}/Transaction";

        /// <summary>"ArticleMarginReport"</summary>
        public const string GetArticleMarginReportList = "ArticleMarginReport";

        /// <summary>"Article/{id}/Post"</summary>
        public const string GetArticlePostByArticleList = "Article/{id}/Post";

        /// <summary>"PartnerArticleStatisticsReport"</summary>
        public const string GetPartnerArticleStatisticsReportList = "PartnerArticleStatisticsReport";

        /// <summary>"PartnerStatisticsReport"</summary>
        public const string GetPartnerStatisticsReportList = "PartnerStatisticsReport";

        /// <summary>"ArticlePostReport"</summary>
        public const string GetArticlePostReportList = "ArticlePostReport";

        /// <summary>"OngoingOrderReport"</summary>
        public const string GetOngoingOrderReportList = "OngoingOrderReport";

        /// <summary>"OngoingOrderHistoricReport"</summary>
        public const string GetOngoingOrderHistoricReportList = "OngoingOrderHistoricReport";

        /// <summary>"EUSalesWithoutVAT"</summary>
        public const string GetEUSalesWithoutVAT = "EUSalesWithoutVAT";

        /// <summary>"ArticleStockReport"</summary>
        public const string GetArticleStockReportList = "ArticleStockReport";

        /// <summary>"ArticleStockStatisticsReport"</summary>
        public const string GetArticleStockStatisticsReportList = "ArticleStockStatisticsReport";

        /// <summary>"ArticleGroupStatisticReport"</summary>
        public const string GetArticleGroupStatisticReportList = "ArticleGroupStatisticReport";

        /// <summary>"LedgerTagStatisticReport"</summary>
        public const string GetLedgerTagStatisticReportList = "LedgerTagStatisticReport";

        /// <summary>"HistoricStockValueReport"</summary>
        public const string GetHistoricStockValueReportList = "HistoricStockValueReport";

        /// <summary>"Settlement/{id}/Post"</summary>
        public const string GetSettledPostList = "Settlement/{id}/Post";

        /// <summary>"PartnerPostReport"</summary>
        public const string GetPartnerPostReportList = "PartnerPostReport";

        /// <summary>"PartnerBalanceReport"</summary>
        public const string GetPartnerBalanceReportList = "PartnerBalanceReport";

        /// <summary>"PartnerBalanceAgeReport"</summary>
        public const string GetPartnerBalanceAgeReportList = "PartnerBalanceAgeReport";

        /// <summary>"LedgerPostReport"</summary>
        public const string GetLedgerPostReportList = "LedgerPostReport";

        /// <summary>"LedgerPostArticleSpecification"</summary>
        public const string GetLedgerPostArticleSpecificationList = "LedgerPostArticleSpecification";

        /// <summary>"VatReconciliationReport"</summary>
        public const string GetVatReconciliationReportList = "VatReconciliationReport";

        /// <summary>"LedgerAccountSpecificationReport"</summary>
        public const string GetLedgerAccountSpecificationReportList = "LedgerAccountSpecificationReport";

        /// <summary>"ArticlePostWithVariant"</summary>
        public const string GetArticlePostWithVariants = "Article/{id}/ArticlePostWithVariant";

        /// <summary>"ArticlePost"</summary>
        public const string GetArticlePostList = "ArticlePost";

        /// <summary>"CancelEconomicTransaction"</summary>
        public const string CancelEconomicTransaction = "{id}/CancelEconomicTransaction";

        /// <summary>"Transaction/{id}/JournalEntry"</summary>
        public const string GetJournalEntryByTransactionList = "{id}/JournalEntry";

        /// <summary>"{id}/LedgerPost"</summary>
        public const string GetLedgerPostByTransactionList = "{id}/LedgerPost";

        /// <summary>"Route"</summary>
        public const string GetLedgerPostBySettlementList = "Settlement/{id}/LedgerPost";

        /// <summary>"Transaction/{id}/ArticlePost"</summary>
        public const string GetArticlePostByTransactionList = "{id}/ArticlePost";

        /// <summary>"Route"</summary>
        public const string GetArticlePostByPhysicalTransactionList = "PhysicalTransaction/{id}/ArticlePost";

        /// <summary>"{id}/PartnerPost"</summary>
        public const string GetPartnerPostByTransactionList = "{id}/PartnerPost";

        /// <summary>"PartnerPost"</summary>
        public const string GetPartnerPostList = "PartnerPost";

        /// <summary>"Settlment/{id}/PartnerPost"</summary>
        public const string GetPartnerPostBySettlementList = "Settlment/{id}/PartnerPost";

        /// <summary>"LedgerGroupData"</summary>
        public const string GetLedgerGroupDataList = "LedgerGroupData";

        /// <summary>"PrimoPartnerPost/{id}/Posts"</summary>
        public const string GetPartnerPostByPrimoPartnerPostList = "PrimoPartnerPost/{id}/Posts";

        /// <summary>"PrimoArticlePost/{id}/Posts"</summary>
        public const string GetArticlePostByPrimoArticlePostList = "PrimoArticlePost/{id}/Posts";

        /// <summary>"PrimoArticlePost/{id}/LedgerPosts"</summary>
        public const string GetLedgerPostByPrimoArticlePostList = "PrimoArticlePost/{id}/LedgerPosts";

        /// <summary>"Partner/{id}/partnerPost"</summary>
        public const string GetPartnerPostByPartnerList = "Partner/{id}/PartnerPost";

        /// <summary>"LedgerGroupDetail"</summary>
        public const string GetLedgerGroupDataDetailList = "LedgerGroupDataDetail";

        /// <summary>"ArticleGroupSalesStatistic"</summary>
        public const string GetArticleGroupSalesStatisticList = "ArticleGroupSalesStatistic";

        /// <summary>"ArticleGroupPurchasingStatistic"</summary>
        public const string GetArticleGroupPurchasingStatisticList = "ArticleGroupPurchasingStatistic";

        /// <summary>"Vat/{id}/LedgerPost"</summary>
        public const string GetLedgerPostByVatList = "Vat/{id}/LedgerPost";

        /// <summary>"LedgerPostsForLedgerAccount"</summary>
        public const string GetLedgerPostForLedgerAccountList = "LedgerPostsForLedgerAccount";

        /// <summary>"PartnerReminder"</summary>
        public const string GetPartnerReminderList = "PartnerReminder";


        /// <summary>"LedgerPost/{id}"</summary>
        public const string GetLedgerPost = "LedgerPost/{id}";

        /// <summary>"XenaPartner"</summary>
        public const string GetXenaPartnerList = "XenaPartner";

        /// <summary>"Partner/{id}/Statement"</summary>
        public const string GetPartnerStatementList = "Partner/{id}/Statement";

        /// <summary>"RenderArticlePostReport"</summary>
        public const string PostRenderArticlePostReportList = "RenderArticlePostReport";

        /// <summary>"RenderEUSalesWithoutVAT"</summary>
        public const string PostRenderEUSalesWithoutVAT = "RenderEUSalesWithoutVAT";

        /// <summary>"RenderArticleStockReport"</summary>
        public const string PostRenderArticleStockReportList = "RenderArticleStockReport";

        /// <summary>"RenderArticleStockStaticsticsReport"</summary>
        public const string PostRenderArticleStockStatisticsReportList = "RenderArticleStockStaticsticsReport";

        /// <summary>"RenderHistoricStockValueReport"</summary>
        public const string PostRenderHistoricStockValueReportList = "RenderHistoricStockValueReport";

        /// <summary>"SendAndRenderArticlePostReport"</summary>
        public const string PostSendAndRenderArticlePostReportList = "SendAndRenderArticlePostReport";

        /// <summary>"SendAndRenderArticleStockReport"</summary>
        public const string PostSendAndRenderArticleStockReportList = "SendAndRenderArticleStockReport";

        /// <summary>"SendAndRenderArticleStockStatisticsReport"</summary>
        public const string PostSendAndRenderArticleStockStatisticsReportList = "SendAndRenderArticleStockStatisticsReport";

        /// <summary>"SendAndRenderHistoricStockValueReport"</summary>
        public const string PostSendAndRenderHistoricStockValueReportList = "SendAndRenderHistoricStockValueReport";

        /// <summary>"SendAndRenderPartnerSaldoAgeReportList"</summary>
        public const string PostSendAndRenderPartnerSaldoAgeReportList = "SendAndRenderPartnerSaldoAgeReportList";

        /// <summary>"PostRenderPartnerPostReportList"</summary>
        public const string PostRenderPartnerPostReportList = "RenderPartnerPostReport";

        /// <summary>"StatisticRenderPartnerStatisticReportList"</summary>
        public const string PostRenderPartnerStatisticReportList = "RenderPartnerStatisticReport";

        /// <summary>"SendAndRenderPartnerPostReport"</summary>
        public const string PostSendAndRenderPartnerPostReportList = "SendAndRenderPartnerPostReport";

        /// <summary>"SendAndRenderPartnerStatisticReport"</summary>
        public const string PostSendAndRenderPartnerStatisticReportList = "SendAndRenderPartnerStatisticReport";

        /// <summary>"RenderPartnerSaldoReport"</summary>
        public const string PostRenderPartnerSaldoReportList = "RenderPartnerSaldoReport";

        /// <summary>"RenderPartnerSaldoAGeReport"</summary>
        public const string PostRenderPartnerSaldoAgeReportList = "RenderPartnerSaldoAgeReport";

        /// <summary>"PartnerBalanceAgeReportTotals"</summary>
        public const string GetPartnerBalanceAgeReportTotals = "PartnerBalanceAgeReportTotals";

        /// <summary>"SendAndRenderPartnerSaldoReport"</summary>
        public const string PostSendAndRenderPartnerSaldoReportList = "SendAndRenderPartnerSaldoReport";

        /// <summary>"RenderResourcePostReport"</summary>
        public const string PostRenderResourcePostReportList = "RenderResourcePostReport";

        /// <summary>"SendAndRenderOrderTaskPostByEmployeeReport"</summary>
        public const string PostSendAndRenderResourcePostReportList = "SendAndRenderResourcePostReport";

        /// <summary>"RenderProjectInProgress"</summary>
        public const string PostRenderProjectInProgressList = "RenderProjectInProgress";

        /// <summary>"RenderOngoingOrdersReport"</summary>
        public const string PostRenderOngoingOrdersList = "RenderOngoingOrdersReport";

        /// <summary>"RenderOngoingOrdersHistoricReport"</summary>
        public const string PostRenderOngoingOrdersHistoricList = "RenderOngoingOrdersHistoricReport";

        /// <summary>"SendAndRenderOrderTaskPostByEmployeeReport"</summary>
        public const string PostSendAndRenderProjectInProgressList = "SendAndRenderProjectInProgress";

        /// <summary>"SendAndRenderOngoingOrders"</summary>
        public const string PostSendAndRenderOngoingOrdersList = "SendAndRenderOngoingOrders";

        /// <summary>"SendAndRenderOngoingOrdersHistoric"</summary>
        public const string PostSendAndRenderOngoingOrdersHistoricList = "SendAndRenderOngoingOrdersHistoric";

        /// <summary>"RenderOrderTaskPostByOrderReport"</summary>
        public const string PostRenderOrderTaskPostByOrderReportList = "RenderOrderTaskPostByOrderReport";

        /// <summary>"SendAndRenderOrderTaskPostByOrderReport"</summary>
        public const string PostSendAndRenderOrderTaskPostByOrderReportList = "SendAndRenderOrderTaskPostByOrderReport";

        /// <summary>"RenderLedgerPostReport"</summary>
        public const string PostRenderLedgerPostReportList = "RenderLedgerPostReport";

        /// <summary>"RenderPartnerArticleStatisticsReport"</summary>
        public const string PostRenderPartnerArticleStatisticsReportList = "RenderPartnerArticleStatisticsReport";

        /// <summary>"RenderArticleGroupStatisticReport"</summary>
        public const string PostRenderArticleGroupStatisticReportList = "RenderArticleGroupStatisticReport";

        /// <summary>"RenderLedgerTagStatisticReport"</summary>
        public const string PostRenderLedgerTagStatisticReportList = "RenderLedgerTagStatisticReport";

        /// <summary>"RenderArticleMarginReport"</summary>
        public const string PostRenderArticleMarginReportList = "RenderArticleMarginReport";

        /// <summary>"SendAndRenderLedgerPostReport"</summary>
        public const string PostSendAndRenderLedgerPostReportList = "SendAndRenderLedgerPostReport";

        /// <summary>"SendAndRenderPartnerArticleStatisticsReport"</summary>
        public const string PostSendAndRenderPartnerArticleStatisticsReportList = "SendAndRenderPartnerArticleStatisticsReport";

        /// <summary>"SendAndRenderArticleGroupStatisticReport"</summary>
        public const string PostSendAndRenderArticleGroupStatisticReportList = "SendAndRenderArticleGroupStatisticReport";

        /// <summary>"SendAndRenderLedgerTagStatisticReport"</summary>
        public const string PostSendAndRenderLedgerTagStatisticReportList = "SendAndRenderLedgerTagStatisticReport";

        /// <summary>"SendAndRenderArticleMarginReport"</summary>
        public const string PostSendAndRenderArticleMarginReportList = "SendAndRenderArticleMarginReport";

        /// <summary>"RenderLedgerAccountSpecification"</summary>
        public const string PostRenderLedgerAccountSpecificationList = "RenderLedgerAccountSpecification";

        /// <summary>"SendAndRenderLedgerAccountSpecification"</summary>
        public const string PostSendAndRenderLedgerAccountSpecificationList = "SendAndRenderLedgerAccountSpecification";

        /// <summary>"FiscalPeriod/{id}/RenderBalanceReport"</summary>
        public const string PostRenderBalanceReportForFiscalPeriod = "FiscalPeriod/{id}/RenderBalanceReport";

        /// <summary>"FiscalPeriod/{id}/SendAndRenderBalanceReport"</summary>
        public const string PostSendAndRenderBalanceReportForFiscalPeriod =
            "FiscalPeriod/{id}/SendAndRenderBalanceReport";

        /// <summary>"FiscalPeriod/{id}/RenderBalanceAccountantReport"</summary>
        public const string PostRenderBalanceAccountantReportForFiscalPeriod =
            "FiscalPeriod/{id}/RenderBalanceAccountantReport";

        /// <summary>"FiscalPeriod/{id}/SendAndRenderBalanceAccountantReport"</summary>
        public const string PostSendAndRenderBalanceAccountantReportForFiscalPeriod =
            "FiscalPeriod/{id}/SendAndRenderBalanceAccountantReport";

        /// <summary>"RenderLedgerTagStatementReport"</summary>
        public const string PostRenderStatementReportForLedgerTag = "LedgerTag/{id}/RenderStatementReport";

        /// <summary>"LedgerTag/{id}/SendAndRenderStatementReport"</summary>
        public const string PostSendAndRenderStatementReportForLedgerTag =
            "LedgerTag/{id}/SendAndRenderStatementReport";

        /// <summary>"RenderVatSettlement"</summary>
        public const string PostRenderVatSettlement = "VatSettlement/{id}/Render";

        /// <summary>"RenderVatStatement"</summary>
        public const string PostRenderVatStatement = "VatSettlement/{id}/RenderVatStatement";

        /// <summary>"RenderPartnerStatement"</summary>
        public const string PostRenderPartnerStatement = "Partner/{id}/RenderStatement";

        /// <summary>"Ledger/{id}/RenderJournal"</summary>
        public const string PostRenderLedgerJournal = "Ledger/{id}/RenderJournal";

        /// <summary>"RenderInvoiceListReport"</summary>
        public const string PostRenderInvoiceListReport = "RenderInvoiceListReport";

        /// <summary>"PostSendAndRenderInvoiceListReport"</summary>
        public const string PostSendAndRenderInvoiceListReport = "PostSendAndRenderInvoiceListReport";

        /// <summary>"PostRenderVatReconciliationReport"</summary>
        public const string PostRenderVatReconciliationReport = "RenderVatReconciliationReport";

        /// <summary>"SendAndRenderVatReconciliationReport"</summary>
        public const string PostSendAndRenderVatReconciliationReport = "SendAndRenderVatReconciliationReport";
    }
}