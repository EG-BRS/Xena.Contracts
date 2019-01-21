using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public class DataImportDto : EntityDto
    {
        [ReadOnly(true)]
        public string Description { get; set; }
        [ReadOnly(true)]
        public bool IsFinished { get; set; }
        [ReadOnly(true)]
        public DateTime? Finished { get; set; }
    }
}