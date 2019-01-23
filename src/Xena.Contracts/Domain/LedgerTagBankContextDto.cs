using System.ComponentModel;
using Xena.Common.ExtensionMethods;

namespace Xena.Contracts.Domain
{
    public class LedgerTagBankContextDto : EntityDto
    {
        public long LedgerTagId { get; set; }
        public string BankExportType { get; set; }
        private string _bankExportTypeTranslated = null;
        [ReadOnly(true)]
        public string BankExportTypeTranslated
        {
            get
            {
                return _bankExportTypeTranslated ?? (string.IsNullOrEmpty(BankExportType)
                           ? string.Empty
                           : BankExportType.GetLocalizedConstant());
            }
            set { _bankExportTypeTranslated = value; }
        }
        public string PaymentMeansType { get; set; }
        private string _paymentMeansTypeTranslated = null;
        [ReadOnly(true)]
        public string PaymentMeansTypeTranslated
        {
            get
            {
                return _paymentMeansTypeTranslated ?? (string.IsNullOrEmpty(PaymentMeansType)
                           ? string.Empty
                           : PaymentMeansType.GetLocalizedConstant());
            }
            set { _paymentMeansTypeTranslated = value; }
        }

        public string Account { get; set; }
        public string AccountIdentifier { get; set; }
        
        //Convinience propertiesS
        public string LedgerTagDescription { get; set; }
        [ReadOnly(true)]
        public int? LedgerTagNumber { get; set; }
    }
}