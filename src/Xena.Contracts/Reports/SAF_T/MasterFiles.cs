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
        [XmlArrayItemAttribute("Account", IsNullable = false)]
        public Account[] GeneralLedgerAccounts { get; set; }

//        /// <remarks/>
//        public AuditFileMasterFilesCustomers Customers { get; set; }
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliers Suppliers { get; set; }
//
//        /// <remarks/>
//        public AuditFileMasterFilesTaxTable TaxTable { get; set; }
//
//        /// <remarks/>
//        [XmlArrayItemAttribute("AnalysisTypeTableEntry", IsNullable = false)]
//        public AuditFileMasterFilesAnalysisTypeTableEntry[] AnalysisTypeTable { get; set; }
//
//        /// <remarks/>
//        [XmlArrayItemAttribute("Owner", IsNullable = false)]
//        public AuditFileMasterFilesOwner[] Owners { get; set; }
    }
}