using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class GeneralLedgerEntries
    {
        /// <remarks/>
        public int NumberOfEntries { get; set; }

        /// <remarks/>
        public decimal TotalDebit { get; set; }

        /// <remarks/>
        public decimal TotalCredit { get; set; }

        /// <remarks/>
        public Journal Journal { get; set; }
    }
}