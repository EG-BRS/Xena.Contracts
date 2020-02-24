using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class Journal
    {
        /// <remarks/>
        public string JournalID { get; set; }

        /// <remarks/>
        public string Description { get; set; }

        /// <remarks/>
        public string Type { get; set; }

        /// <remarks/>
        [XmlElement("Transaction")]
        public Transaction[] Transaction { get; set; }
    }
}