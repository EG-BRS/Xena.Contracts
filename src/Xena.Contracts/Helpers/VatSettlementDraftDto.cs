using System.Collections.Generic;


namespace Xena.Contracts.Helpers
{
    public class VatSettlementPreviewData
    {
        public VatSettlementPreviewData()
        {
            VatSystem = Constants.VatSystems.Xena_VatSystem_Default;
        }
        public string VatSystem { get; set; }
        public IList<VatSettlementPostData> VatPosts { get; set; }
        public IList<VatSettlementTaxPostData> TaxPosts { get; set; }
    }
    public class SettleVatData
    {
        public SettleVatData()
        {
            VatSystem = Constants.VatSystems.Xena_VatSystem_Default;
        }
        public string VatSystem { get; set; }
        public int VatPeriodStart { get; set; }
        public int VatPeriodEnd { get; set; }
        public int PayDate { get; set; }
    }

    public class VatSettlementTaxPostData
    {
        public long LedgerTagId { get; set; }
        public int? LedgerTagNumber { get; set; }
        public string LedgerTagDescription { get; set; }
        public decimal Primo { get; set; }
        public decimal Movement { get; set; }
        public decimal Total
        { get; set; }
    }
    public class VatSettlementPostData
    {
        public long VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public decimal Primo { get; set; }
        public decimal Movement { get; set; }
        public decimal Basis { get; set; }

        public decimal Total
        { get; set; }

        public string VatType { get; set; }
        public string VatTypeTranslated
        { get; set; }
    }
}