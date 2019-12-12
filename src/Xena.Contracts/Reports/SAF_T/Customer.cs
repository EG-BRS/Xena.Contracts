using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Customer
    {
        /// <remarks/>
        public string RegistrationNumber { get; set; }

        /// <remarks/>
        public string Name { get; set; }

        /// <remarks/>
        [XmlElement("Address")]
        public Address[] Address { get; set; }

        /// <remarks/>
        public Contact Contact { get; set; }

        /// <remarks/>
        public TaxRegistration TaxRegistration { get; set; }

        /// <remarks/>
        // public BankAccount BankAccount { get; set; }

        /// <remarks/>
        public string CustomerID { get; set; }

        /// <remarks/>
        public string AccountID { get; set; }

        // /// <remarks/>
        // public decimal OpeningDebitBalance { get; set; }
        //
        // /// <remarks/>
        // public decimal ClosingDebitBalance { get; set; }

        /// <remarks/>
        public PartyInfo PartyInfo { get; set; }
    }
}
