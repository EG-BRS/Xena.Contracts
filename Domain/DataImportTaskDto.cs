using Xena.Resources;

namespace Xena.Contracts.Domain
{
    public class DataImportTaskDto : EntityDto
    {
        public string ImportTaskType { get; set; }

        public string ImportTaskTypeTranslated
        {
            get{return string.IsNullOrEmpty(ImportTaskType) ? string.Empty: ImportTaskType.GetLocalizedConstant();
            }
        }
        public int? TotalToImport { get; set; }
        public int? Imported { get; set; }
        public long DataImportId { get; set; }
        public bool Completed { get; set; }
        public int LogCount { get; set; }
        public bool ManualImport { get; set; }
    }
}