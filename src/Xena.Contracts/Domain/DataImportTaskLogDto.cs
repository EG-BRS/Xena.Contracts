namespace Xena.Contracts.Domain
{
    public class DataImportTaskLogDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long DataImportTaskId { get; set; }
        public string Message { get; set; }
    }
}