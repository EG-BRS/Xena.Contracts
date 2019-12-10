using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class ContactPerson
    {
        /// <remarks/>
        public string FirstName { get; set; }

        /// <remarks/>
        public string Initials { get; set; }

        /// <remarks/>
        public string LastName { get; set; }

        /// <remarks/>
        public string Salutation { get; set; }

        /// <remarks/>
        public string OtherTitles { get; set; }
    }
}