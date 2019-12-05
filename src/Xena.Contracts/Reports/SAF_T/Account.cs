using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Account
    {
        /// <remarks/>
        public int AccountID { get; set; }

        /// <remarks/>
        public string AccountDescription { get; set; }

//        /// <remarks/>
//        public byte StandardAccountID { get; set; }

        /// <remarks/>
        public string AccountType { get; set; }

        /// <remarks/>
        [XmlElementAttribute(DataType = "date")]
        public DateTime AccountCreationDate { get; set; }

        /// <remarks/>
        public decimal OpeningCreditBalance { get; set; }

        /// <remarks/>
        public decimal ClosingCreditBalance { get; set; }

        /// <remarks/>
        public decimal OpeningDebitBalance { get; set; }

        /// <remarks/>
        public decimal ClosingDebitBalance { get; set; }
    }
}