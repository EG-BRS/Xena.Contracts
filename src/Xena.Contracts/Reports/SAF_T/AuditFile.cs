using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    [XmlRoot(Namespace = "urn:StandardAuditFile-Taxation-Financial:NO", IsNullable = false)]
    public class AuditFile
    {
        /// <remarks/>
        public Header Header { get; set; }

        /// <remarks/>
        public MasterFiles MasterFiles { get; set; }

//        /// <remarks/>
//        public AuditFileGeneralLedgerEntries GeneralLedgerEntries { get; set; }
    }
}