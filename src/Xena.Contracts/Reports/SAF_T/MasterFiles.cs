using System;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Xena.Contracts.Reports.SAF_T
{
    [Serializable]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public class MasterFiles
    {
        /// <remarks/>
        [XmlArrayItem("Account", IsNullable = false)]
        public Account[] GeneralLedgerAccounts { get; set; }

        /// <remarks/>
        public Customers Customers { get; set; }

        /// <remarks/>
        public Suppliers Suppliers { get; set; }

        /// <remarks/>
        public TaxTable TaxTable { get; set; }

        /// <remarks/>
        [XmlArrayItem("AnalysisTypeTableEntry", IsNullable = false)]
        public AnalysisTypeTableEntry[] AnalysisTypeTable { get; set; }

        /// <remarks/>
        [XmlArrayItem("Owner", IsNullable = false)]
        public Owner[] Owners { get; set; }
    }
}