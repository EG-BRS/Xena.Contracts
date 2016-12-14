

namespace Xena.Contracts.Domain
{
    public class LedgerTagGroupDto : EntityDto
    {
        public string LedgerAccount { get; set; }
        public string Description { get; set; }
        public int Index { get; set; }
        public string LedgerAccountTranslated
        { get; set; }
    }
}