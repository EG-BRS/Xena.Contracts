using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class BankAccount
    {
        /// <remarks/>
        public ulong BankAccountNumber { get; set; }

        /// <remarks/>
        public string BIC { get; set; }

        /// <remarks/>
        public string CurrencyCode { get; set; }

        /// <remarks/>
        public ushort GeneralLedgerAccountID { get; set; }
    }
}