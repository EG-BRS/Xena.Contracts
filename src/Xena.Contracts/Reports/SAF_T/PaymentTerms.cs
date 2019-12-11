using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class PaymentTerms
    {
        private byte daysField;

        private byte cashDiscountDaysField;

        private decimal cashDiscountRateField;

        private bool freeBillingMonthField;

        /// <remarks/>
        public byte Days
        {
            get { return this.daysField; }
            set { this.daysField = value; }
        }

        /// <remarks/>
        public byte CashDiscountDays
        {
            get { return this.cashDiscountDaysField; }
            set { this.cashDiscountDaysField = value; }
        }

        /// <remarks/>
        public decimal CashDiscountRate
        {
            get { return this.cashDiscountRateField; }
            set { this.cashDiscountRateField = value; }
        }

        /// <remarks/>
        public bool FreeBillingMonth
        {
            get { return this.freeBillingMonthField; }
            set { this.freeBillingMonthField = value; }
        }
    }
}
