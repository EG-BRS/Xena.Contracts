namespace Xena.Contracts.ApiRoutes
{
    public class VatRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/Transaction"</summary>
        public const string Base = "Fiscal/{fiscalId}/Vat";

        /// <summary>"{id}/HasBeenUsed"</summary>
        public const string GetHasBeenUsed = "{id}/HasBeenUsed";

        /// <summary>"VatType"</summary>
        public const string GetVatTypeList = "VatType";

        /// <summary>"ByType"</summary>
        public const string GetByTypeList = "ByType";

        /// <summary>"{id}/DuplicateAccountNumbers"</summary>
        public const string GetDuplicateAccountNumbers = "{id}/DuplicateAccountNumbers";

        /// <summary>"PossibleProblems"</summary>
        public const string GetPossibleVatProblems = "PossibleProblems";

        /// <summary>"{id}/ReconciliationData"</summary>
        public const string GetVatReconciliationDataList = "{id}/ReconciliationData";
    }
}