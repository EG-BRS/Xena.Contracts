using System;
using System.Collections.Generic;
using System.Text;

namespace Xena.Contracts.Reports.SAF_T
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public partial class AuditFileMasterFiles
    {

        private AuditFileMasterFilesGeneralLedgerAccounts generalLedgerAccountsField;

        /// <remarks/>
        public AuditFileMasterFilesGeneralLedgerAccounts GeneralLedgerAccounts
        {
            get
            {
                return this.generalLedgerAccountsField;
            }
            set
            {
                this.generalLedgerAccountsField = value;
            }
        }
    }
}
