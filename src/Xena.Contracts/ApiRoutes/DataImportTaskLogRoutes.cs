namespace Xena.Contracts.ApiRoutes
{
    public class DataImportTaskLogRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/DataImportTask"</summary>
        public const string Base = "Fiscal/{fiscalId}/DataImportTaskLog";

        /// <summary>"~/Fiscal/{fiscalId}/DataImport/{id}/Task"</summary>
        public const string GetByDataImportTask = "~/Fiscal/{fiscalId}/DataImportTask/{id}/Log";
    }
}