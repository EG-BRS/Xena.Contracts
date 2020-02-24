using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Contact
    {
        /// <remarks/>
        public ContactPerson ContactPerson { get; set; }

        /// <remarks/>
        public string Telephone { get; set; }

        // /// <remarks/>
        // public string Fax { get; set; }

        /// <remarks/>
        public string Email { get; set; }

        /// <remarks/>
        public string Website { get; set; }

        /// <remarks/>
        public string MobilePhone { get; set; }
    }
}