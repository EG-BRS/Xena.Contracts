namespace Xena.Contracts.Helpers
{
    public class BaseImportTaskData
    {
        public long TaskId { get; set; }
        public int? TotalToImport { get; set; }
        public int? Imported { get; set; }
        public int Stack { get; set; }
    }
}