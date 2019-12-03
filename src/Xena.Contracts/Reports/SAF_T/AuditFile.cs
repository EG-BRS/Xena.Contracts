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
        private AuditFileMasterFiles masterFilesField;

        /// <remarks/>
        public AuditFileMasterFiles MasterFiles
        {
            get
            {
                return this.masterFilesField;
            }
            set
            {
                this.masterFilesField = value;
            }
        }
    }

    

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public partial class AuditFileMasterFilesGeneralLedgerAccounts
    {

        private AuditFileMasterFilesGeneralLedgerAccountsAccount accountField;

        /// <remarks/>
        public AuditFileMasterFilesGeneralLedgerAccountsAccount Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
    public partial class AuditFileMasterFilesGeneralLedgerAccountsAccount
    {

        private ushort accountIDField;

        private string accountDescriptionField;

        private byte standardAccountIDField;

        private string accountTypeField;

        private System.DateTime accountCreationDateField;

        private uint openingDebitBalanceField;

        private uint closingDebitBalanceField;

        /// <remarks/>
        public ushort AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }

        /// <remarks/>
        public string AccountDescription
        {
            get
            {
                return this.accountDescriptionField;
            }
            set
            {
                this.accountDescriptionField = value;
            }
        }

        /// <remarks/>
        public byte StandardAccountID
        {
            get
            {
                return this.standardAccountIDField;
            }
            set
            {
                this.standardAccountIDField = value;
            }
        }

        /// <remarks/>
        public string AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime AccountCreationDate
        {
            get
            {
                return this.accountCreationDateField;
            }
            set
            {
                this.accountCreationDateField = value;
            }
        }

        /// <remarks/>
        public uint OpeningDebitBalance
        {
            get
            {
                return this.openingDebitBalanceField;
            }
            set
            {
                this.openingDebitBalanceField = value;
            }
        }

        /// <remarks/>
        public uint ClosingDebitBalance
        {
            get
            {
                return this.closingDebitBalanceField;
            }
            set
            {
                this.closingDebitBalanceField = value;
            }
        }
    }


}
