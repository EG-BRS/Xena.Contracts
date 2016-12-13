using Xena.Contracts.Domain;

namespace Xena.Contracts.Reports.VatSpecification
{
    public class LedgerTagSpecificationPostDto
    {
        public LedgerTagSpecificationPostDto(VoucherDto voucher, LedgerPostDto ledgerPost)
        {
            Voucher = voucher;
            LedgerPost = ledgerPost;
        }

        public VoucherDto Voucher { get; private set; }
        public LedgerPostDto LedgerPost { get; private set; }
        public decimal RunningTotal { get; set; }
    }
}