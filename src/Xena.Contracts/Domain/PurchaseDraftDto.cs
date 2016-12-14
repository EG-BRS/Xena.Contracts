namespace Xena.Contracts.Domain
{
    public class PurchaseDraftDto : EntityDto
    {
        public long SupplierId { get; set; }
        public long SupplierContextId { get; set; }
        public string SupplierName { get; set; }
        public int SupplierAccountNumber { get; set; }
    }
}