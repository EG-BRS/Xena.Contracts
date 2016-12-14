using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Xena.Contracts
{
    public static class LedgerAccountIndexTypes
    {
        public const string LedgerAccount = "LedgerAccountIndexType_LedgerAccount";
        public const string LedgerTag = "LedgerAccountIndexType_LedgerTag";
        public const string ArticleGroup = "LedgerAccountIndexType_ArticleGroup";
        public const string Vat = "LedgerAccountIndexType_Vat";
    }
    public static class PaymentMeansTypes
    {
        public const string Bank = "PaymentMeansType_Bank";
        public const string NO_Bank = "PaymentMeansType_NO_Bank";
        public const string NO_Bank_Mod_10 = "PaymentMeansType_NO_Bank_Mod_10";
        public const string NO_Bank_Mod_11 = "PaymentMeansType_NO_Bank_Mod_11";
        public const string DK_Giro_01 = "PaymentMeansType_DK_Giro_01";
        public const string DK_Giro_04 = "PaymentMeansType_DK_Giro_04";
        public const string DK_Giro_15 = "PaymentMeansType_DK_Giro_15";
        public const string DK_FIK_71 = "PaymentMeansType_DK_FIK_71";
        public const string DK_FIK_73 = "PaymentMeansType_DK_FIK_73";
        public const string DK_FIK_75 = "PaymentMeansType_DK_FIK_75";
        public const string DK_Bank = "PaymentMeansType_DK_Bank";
        public const string DK_NemKonto = "PaymentMeansType_DK_NemKonto";
        public const string IBAN_SWIFT = "PaymentMeansType_IBAN_SWIFT";
        public const string IBAN_NON_EU = "PaymentMeansType_IBAN_Non_EU";

        public static string[] All
        { get; set; }

        public static string RemovedAllowedCharacters(this string accountNumber)
        {
            if (string.IsNullOrEmpty(accountNumber))
                return accountNumber;
            return Regex.Replace(accountNumber, @"[\s.-]", "");
        }

        public static string[] ForCountry(string countryAbbrviation)
        {
            var countrySpecific = new List<string>();
            if (countryAbbrviation == "DK")
                countrySpecific.AddRange(Danish);
            if (countryAbbrviation == "NO")
                countrySpecific.AddRange(Norweigan);
            return countrySpecific.Concat(International).ToArray();
        }

        public static string[] Norweigan
        { get; set; }

        public static string[] Danish
        { get; set; }

        public static string[] UsedOnElectronicInvoices
        { get; set; }
        public static string[] International
        { get; set; }

        public static string[] UsedOnInvoices
        { get; set; }

        public static bool AllowsAccount(string paymentMeansType)
        {
            return !DK_NemKonto.Equals(paymentMeansType);
        }
        public static bool AllowsAccountIdentification(string paymentMeansType)
        {
            return new[] { DK_Bank, IBAN_SWIFT }.Contains(paymentMeansType);
        }
        public static bool AllowsBankName(string paymentMeansType)
        {
            return new[] { Bank, NO_Bank, NO_Bank_Mod_10, NO_Bank_Mod_11, DK_Bank, IBAN_NON_EU, IBAN_SWIFT }.Contains(paymentMeansType);
        }
    }
    public static class Constants
    {
#if DEBUG
        public static string ProtocolUsedByXena { get; set; }
#else
        public static string ProtocolUsedByXena { get; set; }
#endif

        public static class AddressProviders
        {
            public const string Xena_VCard = "xena_vcard"; 
            public const string Xena_Partner = "xena_partner"; 
            public const string Xena_Archive = "xena_archive"; 
            public const string DK_Eniro = "dk_eniro"; 
            public const string NO_Eniro = "eniro_no"; 
            public const string DK_CVR = "dk_cvr"; 
            public const string NO_Enhet = "no_enhet"; 

        }
        public static class PartnerTypes
        {
            public const string Xena_Person = "xena_partnertype_person";
            public const string Xena_Company = "xena_partnertype_company"; 
            public const string Xena_Indeterminate = "xena_partnertype_indeterminate";

            public static IEnumerable<string> All
            { get; set; }
        }

        public static class VatSystems
        {
            public const string Xena_VatSystem_Default = "xena_vatsystem_default";
            public const string Xena_VatSystem_OneStop = "xena_vatsystem_onestop";
            public static IEnumerable<string> All { get; set; }
        }
        public static class VatSettlementTypes
        {
            public static IEnumerable<string> DefaultTypes
            { get; set; }
            public static IEnumerable<string> OneStopTypes
            { get; set; }

            public const string Xena_Settlement = "xena_vatsettlement"; 
            public const string Xena_SettlementAdjustment = "xena_vatsettlementadjustment"; 
            public const string Xena_OneStop_Settlement = "xena_onestop_vatsettlement"; 
            public const string Xena_OneStop_SettlementAdjustment = "xena_onestop_vatsettlementadjustment"; 
            public const string Xena_Cancellation = "xena_vatsettlementcancellation"; 
        }
        public static class DueTypes
        {
            public const string Xena_PrePaid = "xena_prepaid"; 
            public const string Xena_Cash = "xena_cash"; 
            public const string Xena_RunningMonth = "xena_running_month"; 
            public const string Xena_Nett = "xena_nett"; 
            public static string[] All = new[] { Xena_Cash, Xena_Nett, Xena_RunningMonth, Xena_PrePaid }; 
        }
        public static class LedgerPostTypes
        {
            public const string Xena_LedgerPostType_Consumption = "xena_ledgerposttype_consumption"; 
            public const string Xena_LedgerPostType_Resale = "xena_ledgerposttype_resale"; 
            public static string[] All { get; set; }
        }

        public static class PartnerHistoryEntryTypes
        {
            public const string Mail = "Mail"; 
            public const string Note = "Note"; 
            public const string Phone = "Phone"; 
            public const string SMS = "SMS"; 
            public const string Invite = "Invite"; 
        }

        public static class EmailOrigins
        {
            public const string Partner = "Partner"; 
            public const string ResourceVCard = "ResourceVCard"; 
            public const string PartnerFiscalVCard = "PartnerFiscalVCard"; 
            public const string PartnerUserVCard = "PartnerUserVCard"; 

        }

        public static class InvoiceIdentiticationTypes
        {
            public const string DanishFIK = "DanishFIK";
            public const string NorweiganKID_Mod10 = "NorweiganKID_Mod10";
            public const string NorweiganKID_Mod11 = "NorweiganKID_Mod11";
        }

        public static class ArticleStatus
        {
            public const string InStock = "xena_inStock"; 
            public const string WillBeInStock = "xena_willBeInStock"; 
            public const string NotInStock = "xena_notInStock"; 

        }
        public static class BankPostingReconciliationSuggestionTypes
        {
            public static IEnumerable<string> All { get; set; }
            public const string LedgerPost = "BankPostingReconciliationSuggestionType_LedgerPost";
            public const string LedgerLine = "BankPostingReconciliationSuggestionType_LedgerLine";
            public const string LedgerPostPreview = "BankPostingReconciliationSuggestionType_LedgerPostPreview";
            public const string PartnerPost = "BankPostingReconciliationSuggestionType_PartnerPost";
            public const string PartnerSaldo = "BankPostingReconciliationSuggestionType_PartnerSaldo";
        }

        public static class Themes
        {
            public const string Standard = "theme-default"; 
            public const string MintGreen = "theme-1"; 
            public const string OceanBlue = "theme-2"; 
            public const string Blue = "theme-3"; 
            public const string NaviBlue = "theme-4"; 
            public const string Purple = "theme-5"; 
            public const string Prikly = "theme-6"; 
            public const string Pink = "theme-7"; 
            public const string Rusty = "theme-8"; 
            public const string Dusty = "theme-9"; 
            public const string Yellow = "theme-10"; 
            public const string LightYellow = "theme-11"; 
            public const string Coffee = "theme-12"; 
            public const string Dark = "theme-13"; 
            public static string[] All { get; set; }
        }

        public static class PartnerContextTypes
        {
            public const string Supplier = "Supplier";
            public const string Customer = "Customer";
            public const string Resource = "Resource";
            public const string All = "All";
            public static string[] AllContextTypes { get; set; }
        }

    }
    public static class ReportModules
    {
        public static string[] All { get; set; }
        public static string[] Printable { get; set; }
        public const string ArticleMarginReportList = "ArticleMarginReportList"; 
        public const string ArticlePostReportList = "ArticlePostReportList"; 
        public const string ArticleStockReportList = "ArticleStockReportList"; 
        public const string FiscalBalance = "FiscalBalance"; 
        public const string FiscalBalanceAccountant = "FiscalBalanceAccountant";
        public const string HistoricStockValueReportList = "HistoricStockValueReportList";
        public const string InventoryCountingList = "InventoryCountingList";
        public const string LedgerAccountSpecificationReportList = "LedgerAccountSpecificationReportList";
        public const string LedgerPostReportList = "LedgerPostReportList";
        public const string LedgerTagStatisticReportList = "LedgerTagStatisticReportList";
        public const string ArticleGroupStatisticReportList = "ArticleGroupStatisticReportList";
        public const string PriceAgreementReportList = "PriceAgreementReportList";

        public const string LedgerJournal = "LedgerJournal"; 
        public const string OrderDelivery = "OrderDelivery"; 
        public const string OrderConfirmation = "OrderConfirmation"; 
        public const string OrderInvoice = "OrderInvoice"; 
        public const string OrderOffer = "OrderOffer"; 
        public const string OrderPickList = "OrderPickList"; 

        public const string PartnerStatisticReportList = "PartnerStatisticReportList"; 
        public const string PartnerPostReportList = "PartnerPostReportList"; 
        public const string PartnerSaldoReportList = "PartnerSaldoReportList"; 
        public const string PartnerSaldoAgeReportList = "PartnerSaldoAgeReportList"; 

        public const string PrimoFiscalBalance = "PrimoFiscalBalance"; 
        public const string Reminder = "Reminder"; 
        public const string VatSettlement = "VatSettlement"; 
        public const string VatSettlement_OneStop = "VatSettlement_OneStop"; 
        public const string EUSalesVatFree = "EUSalesVatFree"; 

    }
}