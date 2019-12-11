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
//        /// <remarks/>
//        public Header Header { get; set; }

        /// <remarks/>
        public MasterFiles MasterFiles { get; set; }

//        /// <remarks/>
//        public AuditFileGeneralLedgerEntries GeneralLedgerEntries { get; set; }
    }

//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomers
//    {
//        private AuditFileMasterFilesCustomersCustomer customerField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomer Customer
//        {
//            get { return this.customerField; }
//            set { this.customerField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomer
//    {
//        private uint registrationNumberField;
//
//        private string nameField;
//
//        private AuditFileMasterFilesCustomersCustomerAddress[] addressField;
//
//        private AuditFileMasterFilesCustomersCustomerContact contactField;
//
//        private AuditFileMasterFilesCustomersCustomerTaxRegistration taxRegistrationField;
//
//        private AuditFileMasterFilesCustomersCustomerBankAccount bankAccountField;
//
//        private ushort customerIDField;
//
//        private ushort accountIDField;
//
//        private decimal openingDebitBalanceField;
//
//        private decimal closingDebitBalanceField;
//
//        private AuditFileMasterFilesCustomersCustomerPartyInfo partyInfoField;
//
//        /// <remarks/>
//        public uint RegistrationNumber
//        {
//            get { return this.registrationNumberField; }
//            set { this.registrationNumberField = value; }
//        }
//
//        /// <remarks/>
//        public string Name
//        {
//            get { return this.nameField; }
//            set { this.nameField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Address")]
//        public AuditFileMasterFilesCustomersCustomerAddress[] Address
//        {
//            get { return this.addressField; }
//            set { this.addressField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerContact Contact
//        {
//            get { return this.contactField; }
//            set { this.contactField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerTaxRegistration TaxRegistration
//        {
//            get { return this.taxRegistrationField; }
//            set { this.taxRegistrationField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerBankAccount BankAccount
//        {
//            get { return this.bankAccountField; }
//            set { this.bankAccountField = value; }
//        }
//
//        /// <remarks/>
//        public ushort CustomerID
//        {
//            get { return this.customerIDField; }
//            set { this.customerIDField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AccountID
//        {
//            get { return this.accountIDField; }
//            set { this.accountIDField = value; }
//        }
//
//        /// <remarks/>
//        public decimal OpeningDebitBalance
//        {
//            get { return this.openingDebitBalanceField; }
//            set { this.openingDebitBalanceField = value; }
//        }
//
//        /// <remarks/>
//        public decimal ClosingDebitBalance
//        {
//            get { return this.closingDebitBalanceField; }
//            set { this.closingDebitBalanceField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerPartyInfo PartyInfo
//        {
//            get { return this.partyInfoField; }
//            set { this.partyInfoField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerAddress
//    {
//        private string streetNameField;
//
//        private string cityField;
//
//        private ushort postalCodeField;
//
//        private string countryField;
//
//        private string addressTypeField;
//
//        /// <remarks/>
//        public string StreetName
//        {
//            get { return this.streetNameField; }
//            set { this.streetNameField = value; }
//        }
//
//        /// <remarks/>
//        public string City
//        {
//            get { return this.cityField; }
//            set { this.cityField = value; }
//        }
//
//        /// <remarks/>
//        public ushort PostalCode
//        {
//            get { return this.postalCodeField; }
//            set { this.postalCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Country
//        {
//            get { return this.countryField; }
//            set { this.countryField = value; }
//        }
//
//        /// <remarks/>
//        public string AddressType
//        {
//            get { return this.addressTypeField; }
//            set { this.addressTypeField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerContact
//    {
//        private AuditFileMasterFilesCustomersCustomerContactContactPerson contactPersonField;
//
//        private uint telephoneField;
//
//        private uint faxField;
//
//        private string emailField;
//
//        private string websiteField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerContactContactPerson ContactPerson
//        {
//            get { return this.contactPersonField; }
//            set { this.contactPersonField = value; }
//        }
//
//        /// <remarks/>
//        public uint Telephone
//        {
//            get { return this.telephoneField; }
//            set { this.telephoneField = value; }
//        }
//
//        /// <remarks/>
//        public uint Fax
//        {
//            get { return this.faxField; }
//            set { this.faxField = value; }
//        }
//
//        /// <remarks/>
//        public string Email
//        {
//            get { return this.emailField; }
//            set { this.emailField = value; }
//        }
//
//        /// <remarks/>
//        public string Website
//        {
//            get { return this.websiteField; }
//            set { this.websiteField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerContactContactPerson
//    {
//        private string firstNameField;
//
//        private string lastNameField;
//
//        /// <remarks/>
//        public string FirstName
//        {
//            get { return this.firstNameField; }
//            set { this.firstNameField = value; }
//        }
//
//        /// <remarks/>
//        public string LastName
//        {
//            get { return this.lastNameField; }
//            set { this.lastNameField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerTaxRegistration
//    {
//        private string taxRegistrationNumberField;
//
//        /// <remarks/>
//        public string TaxRegistrationNumber
//        {
//            get { return this.taxRegistrationNumberField; }
//            set { this.taxRegistrationNumberField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerBankAccount
//    {
//        private string iBANNumberField;
//
//        private string bICField;
//
//        private string currencyCodeField;
//
//        private ushort generalLedgerAccountIDField;
//
//        /// <remarks/>
//        public string IBANNumber
//        {
//            get { return this.iBANNumberField; }
//            set { this.iBANNumberField = value; }
//        }
//
//        /// <remarks/>
//        public string BIC
//        {
//            get { return this.bICField; }
//            set { this.bICField = value; }
//        }
//
//        /// <remarks/>
//        public string CurrencyCode
//        {
//            get { return this.currencyCodeField; }
//            set { this.currencyCodeField = value; }
//        }
//
//        /// <remarks/>
//        public ushort GeneralLedgerAccountID
//        {
//            get { return this.generalLedgerAccountIDField; }
//            set { this.generalLedgerAccountIDField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerPartyInfo
//    {
//        private AuditFileMasterFilesCustomersCustomerPartyInfoPaymentTerms paymentTermsField;
//
//        private decimal naceCodeField;
//
//        private string currencyCodeField;
//
//        private string typeField;
//
//        private string statusField;
//
//        private AuditFileMasterFilesCustomersCustomerPartyInfoAnalysis analysisField;
//
//        private string notesField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerPartyInfoPaymentTerms PaymentTerms
//        {
//            get { return this.paymentTermsField; }
//            set { this.paymentTermsField = value; }
//        }
//
//        /// <remarks/>
//        public decimal NaceCode
//        {
//            get { return this.naceCodeField; }
//            set { this.naceCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string CurrencyCode
//        {
//            get { return this.currencyCodeField; }
//            set { this.currencyCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Type
//        {
//            get { return this.typeField; }
//            set { this.typeField = value; }
//        }
//
//        /// <remarks/>
//        public string Status
//        {
//            get { return this.statusField; }
//            set { this.statusField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesCustomersCustomerPartyInfoAnalysis Analysis
//        {
//            get { return this.analysisField; }
//            set { this.analysisField = value; }
//        }
//
//        /// <remarks/>
//        public string Notes
//        {
//            get { return this.notesField; }
//            set { this.notesField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerPartyInfoPaymentTerms
//    {
//        private byte daysField;
//
//        private byte cashDiscountDaysField;
//
//        private decimal cashDiscountRateField;
//
//        private bool freeBillingMonthField;
//
//        /// <remarks/>
//        public byte Days
//        {
//            get { return this.daysField; }
//            set { this.daysField = value; }
//        }
//
//        /// <remarks/>
//        public byte CashDiscountDays
//        {
//            get { return this.cashDiscountDaysField; }
//            set { this.cashDiscountDaysField = value; }
//        }
//
//        /// <remarks/>
//        public decimal CashDiscountRate
//        {
//            get { return this.cashDiscountRateField; }
//            set { this.cashDiscountRateField = value; }
//        }
//
//        /// <remarks/>
//        public bool FreeBillingMonth
//        {
//            get { return this.freeBillingMonthField; }
//            set { this.freeBillingMonthField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesCustomersCustomerPartyInfoAnalysis
//    {
//        private string analysisTypeField;
//
//        private ushort analysisIDField;
//
//        /// <remarks/>
//        public string AnalysisType
//        {
//            get { return this.analysisTypeField; }
//            set { this.analysisTypeField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AnalysisID
//        {
//            get { return this.analysisIDField; }
//            set { this.analysisIDField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliers
//    {
//        private AuditFileMasterFilesSuppliersSupplier supplierField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplier Supplier
//        {
//            get { return this.supplierField; }
//            set { this.supplierField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplier
//    {
//        private uint registrationNumberField;
//
//        private string nameField;
//
//        private AuditFileMasterFilesSuppliersSupplierAddress[] addressField;
//
//        private AuditFileMasterFilesSuppliersSupplierContact contactField;
//
//        private AuditFileMasterFilesSuppliersSupplierTaxRegistration taxRegistrationField;
//
//        private AuditFileMasterFilesSuppliersSupplierBankAccount bankAccountField;
//
//        private ushort supplierIDField;
//
//        private ushort accountIDField;
//
//        private decimal openingCreditBalanceField;
//
//        private decimal closingCreditBalanceField;
//
//        private AuditFileMasterFilesSuppliersSupplierPartyInfo partyInfoField;
//
//        /// <remarks/>
//        public uint RegistrationNumber
//        {
//            get { return this.registrationNumberField; }
//            set { this.registrationNumberField = value; }
//        }
//
//        /// <remarks/>
//        public string Name
//        {
//            get { return this.nameField; }
//            set { this.nameField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Address")]
//        public AuditFileMasterFilesSuppliersSupplierAddress[] Address
//        {
//            get { return this.addressField; }
//            set { this.addressField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierContact Contact
//        {
//            get { return this.contactField; }
//            set { this.contactField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierTaxRegistration TaxRegistration
//        {
//            get { return this.taxRegistrationField; }
//            set { this.taxRegistrationField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierBankAccount BankAccount
//        {
//            get { return this.bankAccountField; }
//            set { this.bankAccountField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SupplierID
//        {
//            get { return this.supplierIDField; }
//            set { this.supplierIDField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AccountID
//        {
//            get { return this.accountIDField; }
//            set { this.accountIDField = value; }
//        }
//
//        /// <remarks/>
//        public decimal OpeningCreditBalance
//        {
//            get { return this.openingCreditBalanceField; }
//            set { this.openingCreditBalanceField = value; }
//        }
//
//        /// <remarks/>
//        public decimal ClosingCreditBalance
//        {
//            get { return this.closingCreditBalanceField; }
//            set { this.closingCreditBalanceField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierPartyInfo PartyInfo
//        {
//            get { return this.partyInfoField; }
//            set { this.partyInfoField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierAddress
//    {
//        private string streetNameField;
//
//        private byte numberField;
//
//        private bool numberFieldSpecified;
//
//        private string cityField;
//
//        private ushort postalCodeField;
//
//        private string countryField;
//
//        private string addressTypeField;
//
//        /// <remarks/>
//        public string StreetName
//        {
//            get { return this.streetNameField; }
//            set { this.streetNameField = value; }
//        }
//
//        /// <remarks/>
//        public byte Number
//        {
//            get { return this.numberField; }
//            set { this.numberField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool NumberSpecified
//        {
//            get { return this.numberFieldSpecified; }
//            set { this.numberFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public string City
//        {
//            get { return this.cityField; }
//            set { this.cityField = value; }
//        }
//
//        /// <remarks/>
//        public ushort PostalCode
//        {
//            get { return this.postalCodeField; }
//            set { this.postalCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Country
//        {
//            get { return this.countryField; }
//            set { this.countryField = value; }
//        }
//
//        /// <remarks/>
//        public string AddressType
//        {
//            get { return this.addressTypeField; }
//            set { this.addressTypeField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierContact
//    {
//        private AuditFileMasterFilesSuppliersSupplierContactContactPerson contactPersonField;
//
//        private uint telephoneField;
//
//        private uint faxField;
//
//        private string emailField;
//
//        private string websiteField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierContactContactPerson ContactPerson
//        {
//            get { return this.contactPersonField; }
//            set { this.contactPersonField = value; }
//        }
//
//        /// <remarks/>
//        public uint Telephone
//        {
//            get { return this.telephoneField; }
//            set { this.telephoneField = value; }
//        }
//
//        /// <remarks/>
//        public uint Fax
//        {
//            get { return this.faxField; }
//            set { this.faxField = value; }
//        }
//
//        /// <remarks/>
//        public string Email
//        {
//            get { return this.emailField; }
//            set { this.emailField = value; }
//        }
//
//        /// <remarks/>
//        public string Website
//        {
//            get { return this.websiteField; }
//            set { this.websiteField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierContactContactPerson
//    {
//        private string firstNameField;
//
//        private string initialsField;
//
//        private string lastNameField;
//
//        private string salutationField;
//
//        private string otherTitlesField;
//
//        /// <remarks/>
//        public string FirstName
//        {
//            get { return this.firstNameField; }
//            set { this.firstNameField = value; }
//        }
//
//        /// <remarks/>
//        public string Initials
//        {
//            get { return this.initialsField; }
//            set { this.initialsField = value; }
//        }
//
//        /// <remarks/>
//        public string LastName
//        {
//            get { return this.lastNameField; }
//            set { this.lastNameField = value; }
//        }
//
//        /// <remarks/>
//        public string Salutation
//        {
//            get { return this.salutationField; }
//            set { this.salutationField = value; }
//        }
//
//        /// <remarks/>
//        public string OtherTitles
//        {
//            get { return this.otherTitlesField; }
//            set { this.otherTitlesField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierTaxRegistration
//    {
//        private string taxRegistrationNumberField;
//
//        /// <remarks/>
//        public string TaxRegistrationNumber
//        {
//            get { return this.taxRegistrationNumberField; }
//            set { this.taxRegistrationNumberField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierBankAccount
//    {
//        private ulong bankAccountNumberField;
//
//        private string bankAccountNameField;
//
//        private ushort sortCodeField;
//
//        private string bICField;
//
//        private string currencyCodeField;
//
//        private ushort generalLedgerAccountIDField;
//
//        /// <remarks/>
//        public ulong BankAccountNumber
//        {
//            get { return this.bankAccountNumberField; }
//            set { this.bankAccountNumberField = value; }
//        }
//
//        /// <remarks/>
//        public string BankAccountName
//        {
//            get { return this.bankAccountNameField; }
//            set { this.bankAccountNameField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SortCode
//        {
//            get { return this.sortCodeField; }
//            set { this.sortCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string BIC
//        {
//            get { return this.bICField; }
//            set { this.bICField = value; }
//        }
//
//        /// <remarks/>
//        public string CurrencyCode
//        {
//            get { return this.currencyCodeField; }
//            set { this.currencyCodeField = value; }
//        }
//
//        /// <remarks/>
//        public ushort GeneralLedgerAccountID
//        {
//            get { return this.generalLedgerAccountIDField; }
//            set { this.generalLedgerAccountIDField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierPartyInfo
//    {
//        private AuditFileMasterFilesSuppliersSupplierPartyInfoPaymentTerms paymentTermsField;
//
//        private decimal naceCodeField;
//
//        private string currencyCodeField;
//
//        private string typeField;
//
//        private string statusField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesSuppliersSupplierPartyInfoPaymentTerms PaymentTerms
//        {
//            get { return this.paymentTermsField; }
//            set { this.paymentTermsField = value; }
//        }
//
//        /// <remarks/>
//        public decimal NaceCode
//        {
//            get { return this.naceCodeField; }
//            set { this.naceCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string CurrencyCode
//        {
//            get { return this.currencyCodeField; }
//            set { this.currencyCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Type
//        {
//            get { return this.typeField; }
//            set { this.typeField = value; }
//        }
//
//        /// <remarks/>
//        public string Status
//        {
//            get { return this.statusField; }
//            set { this.statusField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesSuppliersSupplierPartyInfoPaymentTerms
//    {
//        private byte monthsField;
//
//        /// <remarks/>
//        public byte Months
//        {
//            get { return this.monthsField; }
//            set { this.monthsField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesTaxTable
//    {
//        private AuditFileMasterFilesTaxTableTaxTableEntry taxTableEntryField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesTaxTableTaxTableEntry TaxTableEntry
//        {
//            get { return this.taxTableEntryField; }
//            set { this.taxTableEntryField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesTaxTableTaxTableEntry
//    {
//        private string taxTypeField;
//
//        private string descriptionField;
//
//        private AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails taxCodeDetailsField;
//
//        /// <remarks/>
//        public string TaxType
//        {
//            get { return this.taxTypeField; }
//            set { this.taxTypeField = value; }
//        }
//
//        /// <remarks/>
//        public string Description
//        {
//            get { return this.descriptionField; }
//            set { this.descriptionField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails TaxCodeDetails
//        {
//            get { return this.taxCodeDetailsField; }
//            set { this.taxCodeDetailsField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesTaxTableTaxTableEntryTaxCodeDetails
//    {
//        private byte taxCodeField;
//
//        private string descriptionField;
//
//        private byte taxPercentageField;
//
//        private string countryField;
//
//        private byte standardTaxCodeField;
//
//        private byte[] baseRateField;
//
//        /// <remarks/>
//        public byte TaxCode
//        {
//            get { return this.taxCodeField; }
//            set { this.taxCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Description
//        {
//            get { return this.descriptionField; }
//            set { this.descriptionField = value; }
//        }
//
//        /// <remarks/>
//        public byte TaxPercentage
//        {
//            get { return this.taxPercentageField; }
//            set { this.taxPercentageField = value; }
//        }
//
//        /// <remarks/>
//        public string Country
//        {
//            get { return this.countryField; }
//            set { this.countryField = value; }
//        }
//
//        /// <remarks/>
//        public byte StandardTaxCode
//        {
//            get { return this.standardTaxCodeField; }
//            set { this.standardTaxCodeField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("BaseRate")]
//        public byte[] BaseRate
//        {
//            get { return this.baseRateField; }
//            set { this.baseRateField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesAnalysisTypeTableEntry
//    {
//        private string analysisTypeField;
//
//        private string analysisTypeDescriptionField;
//
//        private ushort analysisIDField;
//
//        private string analysisIDDescriptionField;
//
//        private System.DateTime startDateField;
//
//        private bool startDateFieldSpecified;
//
//        private System.DateTime endDateField;
//
//        private bool endDateFieldSpecified;
//
//        private string statusField;
//
//        private AuditFileMasterFilesAnalysisTypeTableEntryAnalysis analysisField;
//
//        /// <remarks/>
//        public string AnalysisType
//        {
//            get { return this.analysisTypeField; }
//            set { this.analysisTypeField = value; }
//        }
//
//        /// <remarks/>
//        public string AnalysisTypeDescription
//        {
//            get { return this.analysisTypeDescriptionField; }
//            set { this.analysisTypeDescriptionField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AnalysisID
//        {
//            get { return this.analysisIDField; }
//            set { this.analysisIDField = value; }
//        }
//
//        /// <remarks/>
//        public string AnalysisIDDescription
//        {
//            get { return this.analysisIDDescriptionField; }
//            set { this.analysisIDDescriptionField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime StartDate
//        {
//            get { return this.startDateField; }
//            set { this.startDateField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool StartDateSpecified
//        {
//            get { return this.startDateFieldSpecified; }
//            set { this.startDateFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime EndDate
//        {
//            get { return this.endDateField; }
//            set { this.endDateField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool EndDateSpecified
//        {
//            get { return this.endDateFieldSpecified; }
//            set { this.endDateFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public string Status
//        {
//            get { return this.statusField; }
//            set { this.statusField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesAnalysisTypeTableEntryAnalysis Analysis
//        {
//            get { return this.analysisField; }
//            set { this.analysisField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesAnalysisTypeTableEntryAnalysis
//    {
//        private string analysisTypeField;
//
//        private byte analysisIDField;
//
//        /// <remarks/>
//        public string AnalysisType
//        {
//            get { return this.analysisTypeField; }
//            set { this.analysisTypeField = value; }
//        }
//
//        /// <remarks/>
//        public byte AnalysisID
//        {
//            get { return this.analysisIDField; }
//            set { this.analysisIDField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesOwner
//    {
//        private uint registrationNumberField;
//
//        private bool registrationNumberFieldSpecified;
//
//        private string nameField;
//
//        private AuditFileMasterFilesOwnerAddress addressField;
//
//        private AuditFileMasterFilesOwnerContact contactField;
//
//        private ushort ownerIDField;
//
//        private ushort accountIDField;
//
//        private bool accountIDFieldSpecified;
//
//        /// <remarks/>
//        public uint RegistrationNumber
//        {
//            get { return this.registrationNumberField; }
//            set { this.registrationNumberField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool RegistrationNumberSpecified
//        {
//            get { return this.registrationNumberFieldSpecified; }
//            set { this.registrationNumberFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public string Name
//        {
//            get { return this.nameField; }
//            set { this.nameField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesOwnerAddress Address
//        {
//            get { return this.addressField; }
//            set { this.addressField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileMasterFilesOwnerContact Contact
//        {
//            get { return this.contactField; }
//            set { this.contactField = value; }
//        }
//
//        /// <remarks/>
//        public ushort OwnerID
//        {
//            get { return this.ownerIDField; }
//            set { this.ownerIDField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AccountID
//        {
//            get { return this.accountIDField; }
//            set { this.accountIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool AccountIDSpecified
//        {
//            get { return this.accountIDFieldSpecified; }
//            set { this.accountIDFieldSpecified = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesOwnerAddress
//    {
//        private string streetNameField;
//
//        private string cityField;
//
//        private ushort postalCodeField;
//
//        private string countryField;
//
//        private string addressTypeField;
//
//        /// <remarks/>
//        public string StreetName
//        {
//            get { return this.streetNameField; }
//            set { this.streetNameField = value; }
//        }
//
//        /// <remarks/>
//        public string City
//        {
//            get { return this.cityField; }
//            set { this.cityField = value; }
//        }
//
//        /// <remarks/>
//        public ushort PostalCode
//        {
//            get { return this.postalCodeField; }
//            set { this.postalCodeField = value; }
//        }
//
//        /// <remarks/>
//        public string Country
//        {
//            get { return this.countryField; }
//            set { this.countryField = value; }
//        }
//
//        /// <remarks/>
//        public string AddressType
//        {
//            get { return this.addressTypeField; }
//            set { this.addressTypeField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesOwnerContact
//    {
//        private AuditFileMasterFilesOwnerContactContactPerson contactPersonField;
//
//        /// <remarks/>
//        public AuditFileMasterFilesOwnerContactContactPerson ContactPerson
//        {
//            get { return this.contactPersonField; }
//            set { this.contactPersonField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileMasterFilesOwnerContactContactPerson
//    {
//        private string firstNameField;
//
//        private string lastNameField;
//
//        /// <remarks/>
//        public string FirstName
//        {
//            get { return this.firstNameField; }
//            set { this.firstNameField = value; }
//        }
//
//        /// <remarks/>
//        public string LastName
//        {
//            get { return this.lastNameField; }
//            set { this.lastNameField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntries
//    {
//        private byte numberOfEntriesField;
//
//        private ushort totalDebitField;
//
//        private ushort totalCreditField;
//
//        private AuditFileGeneralLedgerEntriesJournal journalField;
//
//        /// <remarks/>
//        public byte NumberOfEntries
//        {
//            get { return this.numberOfEntriesField; }
//            set { this.numberOfEntriesField = value; }
//        }
//
//        /// <remarks/>
//        public ushort TotalDebit
//        {
//            get { return this.totalDebitField; }
//            set { this.totalDebitField = value; }
//        }
//
//        /// <remarks/>
//        public ushort TotalCredit
//        {
//            get { return this.totalCreditField; }
//            set { this.totalCreditField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileGeneralLedgerEntriesJournal Journal
//        {
//            get { return this.journalField; }
//            set { this.journalField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournal
//    {
//        private string journalIDField;
//
//        private string descriptionField;
//
//        private string typeField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransaction[] transactionField;
//
//        /// <remarks/>
//        public string JournalID
//        {
//            get { return this.journalIDField; }
//            set { this.journalIDField = value; }
//        }
//
//        /// <remarks/>
//        public string Description
//        {
//            get { return this.descriptionField; }
//            set { this.descriptionField = value; }
//        }
//
//        /// <remarks/>
//        public string Type
//        {
//            get { return this.typeField; }
//            set { this.typeField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Transaction")]
//        public AuditFileGeneralLedgerEntriesJournalTransaction[] Transaction
//        {
//            get { return this.transactionField; }
//            set { this.transactionField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransaction
//    {
//        private ushort transactionIDField;
//
//        private byte periodField;
//
//        private ushort periodYearField;
//
//        private System.DateTime transactionDateField;
//
//        private ushort sourceIDField;
//
//        private bool sourceIDFieldSpecified;
//
//        private string transactionTypeField;
//
//        private string descriptionField;
//
//        private byte batchIDField;
//
//        private System.DateTime systemEntryDateField;
//
//        private System.DateTime gLPostingDateField;
//
//        private ushort systemIDField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLine[] lineField;
//
//        /// <remarks/>
//        public ushort TransactionID
//        {
//            get { return this.transactionIDField; }
//            set { this.transactionIDField = value; }
//        }
//
//        /// <remarks/>
//        public byte Period
//        {
//            get { return this.periodField; }
//            set { this.periodField = value; }
//        }
//
//        /// <remarks/>
//        public ushort PeriodYear
//        {
//            get { return this.periodYearField; }
//            set { this.periodYearField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime TransactionDate
//        {
//            get { return this.transactionDateField; }
//            set { this.transactionDateField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SourceID
//        {
//            get { return this.sourceIDField; }
//            set { this.sourceIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool SourceIDSpecified
//        {
//            get { return this.sourceIDFieldSpecified; }
//            set { this.sourceIDFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public string TransactionType
//        {
//            get { return this.transactionTypeField; }
//            set { this.transactionTypeField = value; }
//        }
//
//        /// <remarks/>
//        public string Description
//        {
//            get { return this.descriptionField; }
//            set { this.descriptionField = value; }
//        }
//
//        /// <remarks/>
//        public byte BatchID
//        {
//            get { return this.batchIDField; }
//            set { this.batchIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime SystemEntryDate
//        {
//            get { return this.systemEntryDateField; }
//            set { this.systemEntryDateField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime GLPostingDate
//        {
//            get { return this.gLPostingDateField; }
//            set { this.gLPostingDateField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SystemID
//        {
//            get { return this.systemIDField; }
//            set { this.systemIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Line")]
//        public AuditFileGeneralLedgerEntriesJournalTransactionLine[] Line
//        {
//            get { return this.lineField; }
//            set { this.lineField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLine
//    {
//        private byte recordIDField;
//
//        private ushort accountIDField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLineAnalysis[] analysisField;
//
//        private System.DateTime valueDateField;
//
//        private ushort sourceDocumentIDField;
//
//        private ushort supplierIDField;
//
//        private bool supplierIDFieldSpecified;
//
//        private string descriptionField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLineCreditAmount creditAmountField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLineDebitAmount debitAmountField;
//
//        private uint crossReferenceField;
//
//        private bool crossReferenceFieldSpecified;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformation taxInformationField;
//
//        private uint referenceNumberField;
//
//        private bool referenceNumberFieldSpecified;
//
//        private uint cIDField;
//
//        private bool cIDFieldSpecified;
//
//        private System.DateTime dueDateField;
//
//        private bool dueDateFieldSpecified;
//
//        private System.DateTime systemEntryTimeField;
//
//        private ushort ownerIDField;
//
//        private bool ownerIDFieldSpecified;
//
//        /// <remarks/>
//        public byte RecordID
//        {
//            get { return this.recordIDField; }
//            set { this.recordIDField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AccountID
//        {
//            get { return this.accountIDField; }
//            set { this.accountIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute("Analysis")]
//        public AuditFileGeneralLedgerEntriesJournalTransactionLineAnalysis[] Analysis
//        {
//            get { return this.analysisField; }
//            set { this.analysisField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime ValueDate
//        {
//            get { return this.valueDateField; }
//            set { this.valueDateField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SourceDocumentID
//        {
//            get { return this.sourceDocumentIDField; }
//            set { this.sourceDocumentIDField = value; }
//        }
//
//        /// <remarks/>
//        public ushort SupplierID
//        {
//            get { return this.supplierIDField; }
//            set { this.supplierIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool SupplierIDSpecified
//        {
//            get { return this.supplierIDFieldSpecified; }
//            set { this.supplierIDFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public string Description
//        {
//            get { return this.descriptionField; }
//            set { this.descriptionField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileGeneralLedgerEntriesJournalTransactionLineCreditAmount CreditAmount
//        {
//            get { return this.creditAmountField; }
//            set { this.creditAmountField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileGeneralLedgerEntriesJournalTransactionLineDebitAmount DebitAmount
//        {
//            get { return this.debitAmountField; }
//            set { this.debitAmountField = value; }
//        }
//
//        /// <remarks/>
//        public uint CrossReference
//        {
//            get { return this.crossReferenceField; }
//            set { this.crossReferenceField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool CrossReferenceSpecified
//        {
//            get { return this.crossReferenceFieldSpecified; }
//            set { this.crossReferenceFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformation TaxInformation
//        {
//            get { return this.taxInformationField; }
//            set { this.taxInformationField = value; }
//        }
//
//        /// <remarks/>
//        public uint ReferenceNumber
//        {
//            get { return this.referenceNumberField; }
//            set { this.referenceNumberField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool ReferenceNumberSpecified
//        {
//            get { return this.referenceNumberFieldSpecified; }
//            set { this.referenceNumberFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public uint CID
//        {
//            get { return this.cIDField; }
//            set { this.cIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool CIDSpecified
//        {
//            get { return this.cIDFieldSpecified; }
//            set { this.cIDFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
//        public System.DateTime DueDate
//        {
//            get { return this.dueDateField; }
//            set { this.dueDateField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool DueDateSpecified
//        {
//            get { return this.dueDateFieldSpecified; }
//            set { this.dueDateFieldSpecified = value; }
//        }
//
//        /// <remarks/>
//        public System.DateTime SystemEntryTime
//        {
//            get { return this.systemEntryTimeField; }
//            set { this.systemEntryTimeField = value; }
//        }
//
//        /// <remarks/>
//        public ushort OwnerID
//        {
//            get { return this.ownerIDField; }
//            set { this.ownerIDField = value; }
//        }
//
//        /// <remarks/>
//        [System.Xml.Serialization.XmlIgnoreAttribute()]
//        public bool OwnerIDSpecified
//        {
//            get { return this.ownerIDFieldSpecified; }
//            set { this.ownerIDFieldSpecified = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLineAnalysis
//    {
//        private string analysisTypeField;
//
//        private ushort analysisIDField;
//
//        /// <remarks/>
//        public string AnalysisType
//        {
//            get { return this.analysisTypeField; }
//            set { this.analysisTypeField = value; }
//        }
//
//        /// <remarks/>
//        public ushort AnalysisID
//        {
//            get { return this.analysisIDField; }
//            set { this.analysisIDField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLineCreditAmount
//    {
//        private ushort amountField;
//
//        /// <remarks/>
//        public ushort Amount
//        {
//            get { return this.amountField; }
//            set { this.amountField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLineDebitAmount
//    {
//        private ushort amountField;
//
//        /// <remarks/>
//        public ushort Amount
//        {
//            get { return this.amountField; }
//            set { this.amountField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformation
//    {
//        private string taxTypeField;
//
//        private byte taxCodeField;
//
//        private byte taxPercentageField;
//
//        private ushort taxBaseField;
//
//        private AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformationTaxAmount taxAmountField;
//
//        /// <remarks/>
//        public string TaxType
//        {
//            get { return this.taxTypeField; }
//            set { this.taxTypeField = value; }
//        }
//
//        /// <remarks/>
//        public byte TaxCode
//        {
//            get { return this.taxCodeField; }
//            set { this.taxCodeField = value; }
//        }
//
//        /// <remarks/>
//        public byte TaxPercentage
//        {
//            get { return this.taxPercentageField; }
//            set { this.taxPercentageField = value; }
//        }
//
//        /// <remarks/>
//        public ushort TaxBase
//        {
//            get { return this.taxBaseField; }
//            set { this.taxBaseField = value; }
//        }
//
//        /// <remarks/>
//        public AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformationTaxAmount TaxAmount
//        {
//            get { return this.taxAmountField; }
//            set { this.taxAmountField = value; }
//        }
//    }
//
//    /// <remarks/>
//    [System.SerializableAttribute()]
//    [System.ComponentModel.DesignerCategoryAttribute("code")]
//    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "urn:StandardAuditFile-Taxation-Financial:NO")]
//    public partial class AuditFileGeneralLedgerEntriesJournalTransactionLineTaxInformationTaxAmount
//    {
//        private ushort amountField;
//
//        /// <remarks/>
//        public ushort Amount
//        {
//            get { return this.amountField; }
//            set { this.amountField = value; }
//        }
//    }
}