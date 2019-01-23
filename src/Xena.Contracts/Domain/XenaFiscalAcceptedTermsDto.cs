using System;

namespace Xena.Contracts.Domain
{
    public class XenaFiscalAcceptedTermsDto : XenaFiscalDto
    {
        public DateTime CreatedAt { get; set; }
        public long TermsId { get; set; }
        public long TermsCultureId { get; set; }
        public long ReferenceUserId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public int IsActiveFromDateDays { get; set; }
        public int DeadLineDateDays { get; set; }
        public string CountryName { get; set; }
        public string UserName { get; set; }
        public string FiscalSetupName { get; set; }
    }
}