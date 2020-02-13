using System;
using System.ComponentModel;

namespace Xena.Contracts.Domain
{
    public abstract class FiscalDto
    {
        [ReadOnly(true)]
        public long FiscalSetupId { get; set; }
        [ReadOnly(true)]
        public DateTime CreatedAt { get; set; }
    }
}