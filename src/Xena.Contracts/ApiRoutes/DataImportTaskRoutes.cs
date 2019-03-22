namespace Xena.Contracts.ApiRoutes
{
    public class DataImportTaskRoutes : BaseRoutes
    {
        /// <summary>"Api/Fiscal/{fiscalId}/DataImportTask"</summary>
        public const string Base = "Api/Fiscal/{fiscalId}/DataImportTask";

        /// <summary>"~/Api/Fiscal/{fiscalId}/DataImport/{id}/Task"</summary>
        public const string GetByDataImport = "~/Api/Fiscal/{fiscalId}/DataImport/{id}/Task";
    }
}