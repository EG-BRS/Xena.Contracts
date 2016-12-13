using System.Collections.Generic;
using System.Linq;
using Xena.Contracts.Domain;
using Xena.Resources;

namespace Xena.Contracts.Search
{
    public class LedgerAccountIndex
    {
        public LedgerAccountIndex()
        {
        }

        public LedgerAccountIndex(int? accountNumber, string ledgerAccount, long fiscalSetupId)
        {
            LedgerAccount = ledgerAccount;
            Description = ledgerAccount.GetLocalizedConstant();
            AccountNumber = accountNumber;
            AccountNumberRaw = $"{accountNumber}";
            FiscalSetupId = fiscalSetupId;
            LedgerAccountIndexType = LedgerAccountIndexTypes.LedgerAccount;
            Id = $"{FiscalSetupId}_{ledgerAccount}";
        }

        public LedgerAccountIndex(LedgerTagDto ledgerTag)
        {
            LedgerTagId = ledgerTag.Id;
            LedgerAccount = ledgerTag.LedgerAccount;
            AccountNumber = ledgerTag.Number;
            AccountNumberRaw = $"{ledgerTag.Number}";
            IsDeactivated = ledgerTag.IsDeactivated;
            Description = ledgerTag.Description;
            DefaultDeductionPercentage = ledgerTag.DefaultDeductionPercentage;
            DefaultVatAbbreviation = ledgerTag.DefaultVatAbbreviation;
            DefaultVatId = ledgerTag.DefaultVatId;
            LedgerAccountIndexType = LedgerAccountIndexTypes.LedgerTag;
            Id = $"{ledgerTag.FiscalSetupId}_{LedgerAccountIndexType}_{ledgerTag.Id}";
            FiscalSetupId = ledgerTag.FiscalSetupId;
            ManualBookkeep = true;
            LedgerTagGroupId = ledgerTag.LedgerTagGroupId;
            LedgerTagGroupDescription = ledgerTag.LedgerTagGroupDescription;
        }

        public LedgerAccountIndex(VatDto vat)
        {
            VatId = vat.Id;
            LedgerAccount = LedgerAccounts.VatDebt;
            AccountNumber = vat.LedgerAccount;
            AccountNumberRaw = $"{vat.LedgerAccount}";
            IsDeactivated = vat.IsDeactivated;
            Description = vat.Description;
            LedgerAccountIndexType = LedgerAccountIndexTypes.Vat;
            Id = $"{vat.FiscalSetupId}_{LedgerAccountIndexType}_{vat.Id}";
            FiscalSetupId = vat.FiscalSetupId;
        }

        public static IEnumerable<LedgerAccountIndex> CreateFromArticleGroup(ArticleGroupDto articleGroup, long? defaultSalesVat, string defaultSalesVatAbbreviation, long? defaultPurchaseVat, string defaultPurchaseVatAbbreviation)
        {
            var indexes = new List<LedgerAccountIndex>
            {
                new LedgerAccountIndex(articleGroup, LedgerAccounts.NetTurnover,articleGroup.NettTurnoverVatFreeAccount, true),
                new LedgerAccountIndex(articleGroup, LedgerAccounts.ProductConsumption,articleGroup.ProductPurchaseVatFreeAccount, true),
                new LedgerAccountIndex(articleGroup, LedgerAccounts.Stock,articleGroup.StockAccount, false),
                new LedgerAccountIndex(articleGroup, LedgerAccounts.StockReception,articleGroup.StockReceptionAccount, false),
                new LedgerAccountIndex(articleGroup, LedgerAccounts.UnpaidStock,articleGroup.UnpaidStockAccount, false),
            };
            if (defaultSalesVat.HasValue)
            {
                indexes.Add(new LedgerAccountIndex(articleGroup, LedgerAccounts.NetTurnover, articleGroup.NettTurnoverAccount, true, defaultSalesVat,defaultSalesVatAbbreviation));
            }
            if (defaultPurchaseVat.HasValue)
            {
                indexes.Add(new LedgerAccountIndex(articleGroup, LedgerAccounts.ProductConsumption, articleGroup.ProductPurchaseAccount, true, defaultPurchaseVat, defaultPurchaseVatAbbreviation));
            }
            return indexes;
        }

        private LedgerAccountIndex(ArticleGroupDto articleGroup, string ledgerAccount, int? account, bool manualBookkeep, long? defaultVatId = null, string defaultVatAbbreviation = null)
        {
            LedgerAccount = ledgerAccount;
            IsDeactivated = articleGroup.IsDeactivated;
            ArticleGroupId = articleGroup.Id;
            Description = articleGroup.Description;
            ManualBookkeep = manualBookkeep;
            DefaultVatId = defaultVatId;
            DefaultVatAbbreviation = defaultVatAbbreviation;
            DefaultDeductionPercentage = DefaultVatId.HasValue ? 100m : 0;
            LedgerAccountIndexType = LedgerAccountIndexTypes.ArticleGroup;
            AccountNumber = account;
            AccountNumberRaw = $"{account}";
            Id = $"{articleGroup.FiscalSetupId}_{LedgerAccountIndexType}_{articleGroup.Id}_{ledgerAccount}_{defaultVatId}";
            FiscalSetupId = articleGroup.FiscalSetupId;
        }

        public string Id { get; set; }
        public long? ArticleGroupId { get; set; }
        public long? LedgerTagId { get; set; }
        public int? AccountNumber { get; set; }
        public string AccountNumberRaw { get; set; }
        public string Description { get; set; }
        public string ShortDescription => AccountNumber.HasValue ? $"{AccountNumber.Value}" : GetDescription();
        public string LongDescription => AccountNumber.HasValue ? $"{AccountNumber.Value} {GetDescription()}" : GetDescription();
        public string LedgerAccount { get; set; }
        public long? VatId { get; set; }
        public long? DefaultVatId { get; set; }
        public decimal? DefaultDeductionPercentage { get; set; }
        public string DefaultVatAbbreviation { get; set; }
        public bool ManualBookkeep { get; set; }
        public string LedgerTagGroupDescription { get; set; }
        public long? LedgerTagGroupId { get; set; }
        public string LedgerAccountIndexType { get; set; }
        public long FiscalSetupId { get; set; }
        public bool IsDeactivated { get; set; }
        public string GetDescription()
        {
            return ArticleGroupId.HasValue ? $"{Description}, {LedgerAccount.GetLocalizedConstant()} " + GetVatDescription() : Description;
        }

        private string GetVatDescription() => DefaultVatId.HasValue
            ? Constant.WithVAT
            : Constant.WithoutVAT;

        protected bool Equals(LedgerAccountIndex other)
        {
            return string.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((LedgerAccountIndex)obj);
        }

        public override int GetHashCode()
        {
            return Id?.GetHashCode() ?? 0;
        }
    }
}