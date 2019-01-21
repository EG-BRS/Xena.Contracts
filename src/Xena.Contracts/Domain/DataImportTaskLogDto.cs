using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class DataImportTaskLogDto : IHasIdDto
    {
        [ReadOnly(true)]
        public long? Id { get; set; }
        [ReadOnly(true)]
        public long DataImportTaskId { get; set; }
        [ReadOnly(true)]
        public string Message { get; set; }
    }
}