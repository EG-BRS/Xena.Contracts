using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class PaymentTerms
    {

        /// <remarks/>
        public byte Days { get; set; }

        /// <remarks/>
        public byte CashDiscountDays { get; set; }

        /// <remarks/>
        public decimal CashDiscountRate { get; set; }

        /// <remarks/>
        public bool FreeBillingMonth { get; set; }
    }
}
