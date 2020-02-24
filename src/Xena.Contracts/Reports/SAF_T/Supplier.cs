using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Supplier
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

        // /// <remarks/>
        // public BankAccount BankAccount { get; set; }

        /// <remarks/>
        public string SupplierID { get; set; }

        /// <remarks/>
        public string AccountID { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool OpeningDebitBalanceSpecified { get; set; }

        /// <remarks/>
        public decimal OpeningDebitBalance { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool OpeningCreditBalanceSpecified { get; set; }

        /// <remarks/>
        public decimal OpeningCreditBalance { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ClosingDebitBalanceSpecified { get; set; }

        /// <remarks/>
        public decimal ClosingDebitBalance { get; set; }

        /// <remarks/>
        [XmlIgnore]
        public bool ClosingCreditBalanceSpecified { get; set; }

        /// <remarks/>
        public decimal ClosingCreditBalance { get; set; }

        /// <remarks/>
        public PartyInfo PartyInfo { get; set; }
    }
}