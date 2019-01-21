using System;

namespace Xena.Contracts.Domain
{
    public class XenaUserRejectedTermsDto : XenaUserDto
    {
        public DateTime CreatedAt { get; set; }
        public long TermsId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public int IsActiveFromDateDays { get; set; }
        public int DeadLineDateDays { get; set; }
        public string CountryName { get; set; }
    }
}