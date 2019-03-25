namespace Xena.Contracts.ApiRoutes
{
    public class DataImportTaskRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/DataImportTask"</summary>
        public const string Base = "Fiscal/{fiscalId}/DataImportTask";

        /// <summary>"~/Fiscal/{fiscalId}/DataImport/{id}/Task"</summary>
        public const string GetByDataImport = "~/Fiscal/{fiscalId}/DataImport/{id}/Task";
    }
}