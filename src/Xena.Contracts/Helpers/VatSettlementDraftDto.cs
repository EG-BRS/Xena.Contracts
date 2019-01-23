using System.Collections.Generic;
using System.ComponentModel;
using Xena.Common.Constants;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Helpers
{
    public class VatSettlementPreviewData
    {
        public VatSettlementPreviewData()
        {
            VatSystem = VatSystems.Xena_VatSystem_Default;
        }
        public string VatSystem { get; set; }
        public IList<VatSettlementPostData> VatPosts { get; set; }
        public IList<VatSettlementTaxPostData> TaxPosts { get; set; }
    }
    public class SettleVatData
    {
        public SettleVatData()
        {
            VatSystem = VatSystems.Xena_VatSystem_Default;
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
        private decimal? _total = null;
        [ReadOnly(true)]
        public decimal Total
        {
            get { return _total ?? (Primo + Movement); }
            set { _total = value; }
        }
    }
    public class VatSettlementPostData
    {
        public long VatId { get; set; }
        public string VatAbbreviation { get; set; }
        public decimal Primo { get; set; }
        public decimal Movement { get; set; }
        public decimal Basis { get; set; }

        private decimal? _total = null;
        [ReadOnly(true)]
        public decimal Total
        {
            get { return _total ?? (Primo + Movement); }
            set { _total = value; }
        }

        public string VatType { get; set; }
        private string _vatTypeTranslated = null;
        [ReadOnly(true)]
        public string VatTypeTranslated
        {
            get
            {
                return _vatTypeTranslated ??
                       (string.IsNullOrEmpty(VatType) ? string.Empty : VatType.GetLocalizedConstant());
            }
            set { _vatTypeTranslated = value; }
        }
    }
}