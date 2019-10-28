using System;

namespace Xena.Contracts.ApiRoutes
{
    public class LedgerLineRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/LedgerLine"</summary>
        public const string Base = "Fiscal/{fiscalId}/LedgerLine";

        /// <summary>"Multiple"</summary>
        public const string PostMultiple = "{ledgerId}/Multiple";

        /// <summary>"KID/Multiple"</summary>
        [Obsolete("It will be replace with PostPayment")]
        public const string PostMultipleFromKID = "{ledgerId}/KIDMultiple";

        /// <summary>"Payment"</summary>
        public const string PostPayment = "{ledgerId}/Payment";

        /// <summary>"Bulk"</summary>
        public const string PostBulk = "{ledgerId}/Bulk";
         
        /// <summary>"~/Api/Fiscal/{fiscalId}/Ledger/{id}/Line"</summary>
        public const string GetByLedgerList = "~/Fiscal/{fiscalId}/Ledger/{id}/Line";

        /// <summary>"LedgerLineType"</summary>
        public const string GetLedgerLineTypeList = "LedgerLineType";

        /// <summary>"~/Api/Fiscal/{fiscalId}/Ledger/{id}/ReorderLines"</summary>
        public const string PutReorderLines = "~/Fiscal/{fiscalId}/Ledger/{id}/ReorderLines";


    }
}