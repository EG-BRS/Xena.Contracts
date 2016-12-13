using System;

namespace Xena.Contracts.Domain
{
    public class DataImportDto : EntityDto
    {
        public string Description { get; set; }
        public bool IsFinished { get; set; }
        public DateTime? Finished { get; set; }
    }
}