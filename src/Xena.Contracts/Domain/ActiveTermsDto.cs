using System.Collections.Generic;

namespace Xena.Contracts.Domain
{
    public class ActiveTermsDto : IHasIdDto
    {
        public long? Id { get; set; }
        public long ProviderId { get; set; }
        public IList<UnhandledTermsCultureDto> AvailableCultures { get; set; }
        public int IsActiveFromDateDays { get; set; }
        public int DeadLineDateDays { get; set; }
        public string TermsType { get; set; }
        public bool IsRejected { get; set; }
    }
}