using System.Collections.Generic;
using System.Linq;

namespace Xena.Contracts
{
    public static class LedgerAccounts
    {
        public static class Groups
        {
            public const string Income = "Xena_Domain_Income_Accounts";
            public const string Assets = "Xena_Domain_Asset_Accounts";
            public const string Liabilities = "Xena_Domain_Liability_Accounts";
            public static string[] All { get; set; }
        }

        private static readonly Dictionary<string, IEnumerable<string>> _allAccounts = new Dictionary<string, IEnumerable<string>>();
        static LedgerAccounts()
        {
            _allAccounts.Add(Groups.Income, new[]
                           {
                               NetTurnover, ProductConsumption, Wages, SalesCosts, ProductionCosts, SystemDifferences, HousingCosts, AdministrationCosts,
                               Depreciations, ConsolidationResult, FinancialCosts, Taxes
                           });
            _allAccounts.Add(Groups.Assets, new[]
                           {
                               IntangibleFixedAssets, TangibleFixedAssets, FinancialFixedAssets, Stock,ManualStock, StockReception, CustomerReceivables
                               , OtherReceivables, AdvancePayments, Cash
                           });
            _allAccounts.Add(Groups.Liabilities, new[] { Equity, Provisions, LongTermDebt, UnpaidStock, TradePayables, OtherShortTermDebt, VatDebt });
        }
        public static IEnumerable<string> GetGroup(string accountGroup)
        {
            return _allAccounts[accountGroup];
        }
        public static IEnumerable<string> AllAccounts
        { get; set; }
        public static IEnumerable<string> ArticleGroupRelated { get; set; }
        public static IEnumerable<string> CannotUpdatePrimo { get; set; }
        public static IEnumerable<string> GroupsAllowingSystem { get; set; }
        public static IEnumerable<string> GroupsAllowingLedgerTags { get; set; }
        public static IEnumerable<string> GroupsNotAllowingLedgerTags { get; set; }
        public static IEnumerable<string> GroupsAllowingArticleGroups { get; set; }
        public static IEnumerable<string> GroupsAllowingArticleGroupAndVAT { get; set; }
        public static IEnumerable<string> GroupsAllowingPartners { get; set; }
        public static IEnumerable<string> GroupsAllowingVats { get; set; }
        public static IEnumerable<string> GetOnAllowedLedgerTags(string accountGroup)
        {
            return _allAccounts[accountGroup].Except(GroupsNotAllowingLedgerTags);
        }
        #region Income accounts
        public static KeyValuePair<string, IEnumerable<string>> AllIncomeAccounts { get; set; }
        public const string NetTurnover = "Xena_Domain_Income_Accounts_Net_Turn_Over"; 
        public const string ProductConsumption = "Xena_Domain_Income_Accounts_Product_Consumption"; 
        public const string SalesCosts = "Xena_Domain_Income_Accounts_Sales_Costs"; 
        public const string ProductionCosts = "Xena_Domain_Income_Accounts_Production_Costs"; 
        public const string Wages = "Xena_Domain_Income_Accounts_Wages"; 
        public const string AdministrationCosts = "Xena_Domain_Income_Accounts_Administration_Costs"; 
        public const string HousingCosts = "Xena_Domain_Income_Accounts_Housing_Costs"; 
        public const string Depreciations = "Xena_Domain_Income_Accounts_Depreciation"; 
        public const string ConsolidationResult = "Xena_Domain_Income_Accounts_Consolidation_Result"; 
        public const string FinancialCosts = "Xena_Domain_Income_Accounts_Financial_Costs"; 
        public const string Taxes = "Xena_Domain_Income_Accounts_Taxes"; 
        public const string SystemDifferences = "Xena_Domain_Income_Accounts_System_Differences"; 
        #endregion
        #region AssetAccounts

        public static KeyValuePair<string, IEnumerable<string>> AllAssetAccounts { get; set; }
        public const string AdvancePayments = "Xena_Domain_Asset_Accounts_Advance_Payments"; 
        public const string Cash = "Xena_Domain_Asset_Accounts_Cash"; 
        public const string CustomerReceivables = "Xena_Domain_Asset_Accounts_Customer_Receivables"; 
        public const string FinancialFixedAssets = "Xena_Domain_Asset_Accounts_Financial_Fixed_Asset"; 
        public const string IntangibleFixedAssets = "Xena_Domain_Asset_Accounts_Intangible_Fixed_Asset"; 
        public const string OtherReceivables = "Xena_Domain_Asset_Accounts_Other_Receivables"; 
        public const string Stock = "Xena_Domain_Asset_Accounts_Stock"; 
        public const string ManualStock = "Xena_Domain_Asset_Accounts_ManualStock"; 
        public const string TangibleFixedAssets = "Xena_Domain_Asset_Accounts_Tangible_Fixed_Asset"; 
        public const string StockReception = "Xena_Domain_Asset_Accounts_Stock_Reception"; 
        #endregion
        #region Liability accounts

        public static KeyValuePair<string, IEnumerable<string>> AllLiabilityAccounts { get; set; }

        public const string Equity = "Xena_Domain_Liability_Accounts_Equity";
        public const string Provisions = "Xena_Domain_Liability_Accounts_Provisions";
        public const string LongTermDebt = "Xena_Domain_Liability_Accounts_Long_Term_Debt";
        public const string TradePayables = "Xena_Domain_Liability_Accounts_Trade_Payables";
        public const string OtherShortTermDebt = "Xena_Domain_Liability_Accounts_Other_Short_Term_Debt";
        public const string VatDebt = "Xena_Domain_Liability_Accounts_Vat_Debt";
        public const string UnpaidStock = "Xena_Domain_Liability_Accounts_UnPaid_Stock";


        #endregion
    }
}