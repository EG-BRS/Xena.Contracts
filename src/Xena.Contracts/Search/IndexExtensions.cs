using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xena.Contracts.Domain;

namespace Xena.Contracts.Search
{
    public static class IndexExtensions
    {
        public static ArticleVariantSearchIndex CreateSearchIndex(this ArticleVariantDto articleVariant, Func<long, ArticleDto> getArticle)
        {
            var article = getArticle(articleVariant.ArticleId);
            return new ArticleVariantSearchIndex
            {
                Id = articleVariant.Id.Value,
                ArticleNumber = article == null ? string.Empty : article.ArticleNumber,
                ArticleNumberRaw = article == null ? string.Empty : article.ArticleNumber,
                ArticleDescription = article == null ? string.Empty : article.Description,
                Abbreviation = articleVariant.Abbreviation,
                AbbreviationRaw = articleVariant.Abbreviation,
                Description = articleVariant.Description,
                FiscalSetupId = articleVariant.FiscalSetupId,
                GroupDescription = article == null ? string.Empty : article.ArticleGroupDescription
            };
        }

        public static LocationSearchIndex CreateSearchIndex(this LocationDto location)
        {
            var dimensions = new StringBuilder(location.WarehouseDescription);
            dimensions.AppendFormat(" {0} {1} {2} {3} {4}", location.WarehouseDimension1Description, location.WarehouseDimension2Description, location.WarehouseDimension3Description, location.WarehouseDimension4Description, location.WarehouseDimension5Description);
            dimensions.AppendFormat(" {0} {1} {2} {3} {4}", location.Dimension1, location.Dimension2, location.Dimension3, location.Dimension4, location.Dimension5);

            return new LocationSearchIndex
            {
                Abbreviation = location.Abbreviation,
                Description = location.Description,
                LocationType = location.LocationType,
                IndexedDimensions = dimensions.ToString(),
                Id = location.Id.Value,
                FiscalSetupId = location.FiscalSetupId
            };
        }

        public static IEnumerable<LedgerAccountIndex> CreateLedgerSearchIndex(this ArticleGroupDto articleGroup, FiscalSetupDto fiscalSetup)
        {
            return LedgerAccountIndex.CreateFromArticleGroup(articleGroup, fiscalSetup.DefaultSalesVatId, fiscalSetup.DefaultSalesVatAbbreviation, fiscalSetup.DefaultPurchasingVatId, fiscalSetup.DefaultPurchasingVatAbbreviation);
        }
        public static LedgerAccountIndex CreateLedgerSearchIndex(this VatDto vat)
        {
            return new LedgerAccountIndex(vat);
        }

        public static LedgerAccountIndex CreateLedgerSearchIndex(this LedgerTagDto ledgerTag)
        {
            return new LedgerAccountIndex(ledgerTag);
        }
        public static LedgerTagSearchIndex CreateSearchIndex(this LedgerTagDto ledgerTag)
        {
            return new LedgerTagSearchIndex
            {
                Description = ledgerTag.Description,
                Number = ledgerTag.Number,
                NumberRaw = $"{ledgerTag.Number}",
                LedgerAccount = ledgerTag.LedgerAccount,
                Id = ledgerTag.Id.Value,
                FiscalSetupId = ledgerTag.FiscalSetupId
            };
        }

        public static VoucherSearchIndex CreateSearchIndex(this VoucherDto voucher, Func<long, string> getLineDescriptions)
        {
            return new VoucherSearchIndex
            {
                Description = voucher.Description,
                FiscalSetupId = voucher.FiscalSetupId,
                Id = voucher.Id.Value,
                VoucherNumber = voucher.VoucherNumber,
                VoucherNumberRaw = string.Format("{0}", voucher.VoucherNumber),
                LineDescriptions = getLineDescriptions(voucher.Id.Value)
            };
        }

        public static ArticleSearchIndex CreateSearchIndex(this ArticleDto article)
        {
            return new ArticleSearchIndex
            {
                Id = article.Id.Value,
                ArticleNumber = article.ArticleNumber,
                ArticleNumberRaw = article.ArticleNumber,
                Description = article.Description,
                FiscalSetupId = article.FiscalSetupId,
                GroupDescription = article.ArticleGroupDescription
            };
        }

        public static DocumentSearchIndex CreateSearchIndex(this DocumentDto document, Func<long, long[]> getFiscalSetupIds, Func<long, long[]> getUserIds, Func<long, string> getDocumentContent)
        {
            return new DocumentSearchIndex
            {
                Description = document.Description,
                Id = document.Id.Value,
                FiscalSetupIds = getFiscalSetupIds(document.Id.Value),
                UserIds = getUserIds(document.Id.Value),
                DocumentContent = getDocumentContent(document.Id.Value)
            };
        }

        public static OrderSearchIndex CreateSearchIndex(this OrderDto order, Func<long, IList<string>> getSupplierNumbers)
        {
            var orderNumberToStringed = order.OrderNumber.ToString();
            var orderNumberParts = new string[orderNumberToStringed.Length];
            for (int i = 0; i < orderNumberToStringed.Length; i++)
            {
                orderNumberParts[i] = orderNumberToStringed.Substring(orderNumberToStringed.Length - i - 1);
            }

            return new OrderSearchIndex
            {
                Id = order.Id.Value,
                IsDeactivated = order.IsDeactivated,
                FiscalSetupId = order.FiscalSetupId,
                OrderNumberSplits = string.Join(" ", orderNumberParts),
                Name = order.Address.Name,
                PlaceName = order.Address.PlaceName,
                City = order.Address.City,
                Zip = order.Address.Zip,
                Street = order.Address.Street,
                CountryName = order.Address.CountryName,
                DeliveryName = order.DeliveryAddress == null ? null : order.DeliveryAddress.Name,
                DeliveryPlaceName = order.DeliveryAddress == null ? null : order.DeliveryAddress.PlaceName,
                DeliveryCity = order.DeliveryAddress == null ? null : order.DeliveryAddress.City,
                DeliveryZip = order.DeliveryAddress == null ? null : order.DeliveryAddress.Zip,
                DeliveryStreet = order.DeliveryAddress == null ? null : order.DeliveryAddress.Street,
                DeliveryCountryName = order.DeliveryAddress == null ? null : order.DeliveryAddress.CountryName,
                PartnerName = order.PartnerName,
                OurReference = order.OurReference,
                PartnerId = order.PartnerId,
                PartnerAccountNumber = order.PartnerAccountNumber,
                PartnerPhoneNumber = order.PartnerPhoneNumber,
                YourReference = order.YourReference,
                SupplierInvoiceNumbers = getSupplierNumbers(order.Id.Value),
                ContextType = order.ContextType,
                IsFullyDelivered = order.Summary.IsFullyDelivered,
                IsFullyInvoiced = order.Summary.IsFullyInvoiced,
                OrderStatusId = order.OrderStatusId,
                ResponsibleId = order.ResponsibleId,
            };
        }
        public static SubscriptionSearchIndex CreateSearchIndex(this SubscriptionDto article)
        {
            return new SubscriptionSearchIndex
            {
                Id = article.Id.Value,
                Description = article.Description,
                FiscalSetupId = article.FiscalSetupId,
                Details = article.Details
            };
        }

        public static string StripTelephoneNumber(this string telephoneNumber)
        {
            if (telephoneNumber == null)
                return string.Empty;
            return Regex.Replace(telephoneNumber, @"\D", "");
        }
    }
}