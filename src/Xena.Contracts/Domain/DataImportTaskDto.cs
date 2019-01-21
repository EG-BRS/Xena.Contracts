using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class DataImportTaskDto : EntityDto
    {
        [ReadOnly(true)]
        public string ImportTaskType { get; set; }
        [ReadOnly(true)]
        public int? TotalToImport { get; set; }
        [ReadOnly(true)]
        public int? Imported { get; set; }
        [ReadOnly(true)]
        public long DataImportId { get; set; }
        [ReadOnly(true)]
        public bool Completed { get; set; }
        [ReadOnly(true)]
        public int LogCount { get; set; }
        [ReadOnly(true)]
        public bool ManualImport { get; set; }

        private string _importTaskTypeTranslated = null;
        [ReadOnly(true)]
        public string ImportTaskTypeTranslated
        {
            get
            {
                return _importTaskTypeTranslated ?? (string.IsNullOrEmpty(ImportTaskType)
                           ? string.Empty
                           : ImportTaskType.GetLocalizedConstant());
            }
            set { _importTaskTypeTranslated = value; }
        }
    }
}