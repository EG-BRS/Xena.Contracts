using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Company
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
    }
}