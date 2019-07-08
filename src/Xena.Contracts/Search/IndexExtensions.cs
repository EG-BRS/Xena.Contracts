using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xena.Common.ExtensionMethods;
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
        public static LedgerTagSearchIndex CreateSearchIndex(this LedgerTagDto ledgerTag, Func<long, long, IList<object>> getLedgerMetaData)
        {
            return new LedgerTagSearchIndex
            {
                Description = ledgerTag.Description,
                Number = ledgerTag.Number,
                NumberRaw = $"{ledgerTag.Number}",
                LedgerAccount = ledgerTag.LedgerAccount,
                Id = ledgerTag.Id.Value,
                FiscalSetupId = ledgerTag.FiscalSetupId,
                MetaData = getLedgerMetaData(ledgerTag.FiscalSetupId, ledgerTag.Id.Value)
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
                VoucherNumberRaw = $"{voucher.VoucherNumber}",
                LineDescriptions = getLineDescriptions(voucher.Id.Value)
            };
        }

        public static ArticleSearchIndex CreateSearchIndex(this ArticleDto article, Func<long, long, IList<object>> getArticleMetaData)
        {
            return new ArticleSearchIndex
            {
                Id = article.Id.Value,
                ArticleNumber = article.ArticleNumber,
                ArticleNumberRaw = article.ArticleNumber,
                Description = article.Description,
                FiscalSetupId = article.FiscalSetupId,
                GroupDescription = article.ArticleGroupDescription,
                MetaData = getArticleMetaData(article.FiscalSetupId, article.Id.Value)
            };
        }
        public static FiscalSetupSearchIndex CreateSearchIndex(this FiscalSetupDto fiscalSetup, PartnerDto partner, Func<long, long, IList<object>> getFiscalSetupMetaData)
        {
            return new FiscalSetupSearchIndex
            {
                Id = fiscalSetup.Id.Value,
                IsDeactivated = fiscalSetup.IsDeactivated,
                ProviderId = fiscalSetup.ProviderId,
                Name = fiscalSetup.Address.Name,
                Street = fiscalSetup.Address.Street,
                PlaceName = fiscalSetup.Address.PlaceName,
                Zip = fiscalSetup.Address.Zip,
                City = fiscalSetup.Address.City,
                CountryName = fiscalSetup.Address.CountryName,
                OrgNumber = fiscalSetup.OrgNumber,
                XenaSubscriptionId = fiscalSetup.XenaSubscriptionId,
                PartnerId = partner?.Id,
                AccountNumber = partner?.AccountNumber,
                CreatedDate = fiscalSetup.CreatedAt.Date.DaysSince1970_01_01(),
                Tags = partner?.Tags ?? new List<string>(),
                MetaData = getFiscalSetupMetaData(fiscalSetup.Id.Value, fiscalSetup.Id.Value)
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
                DocumentContent = getDocumentContent(document.Id.Value),
                FileName = document.LastFileName?.Replace('_', ' ') ?? string.Empty
            };
        }

        public static ProjectSearchIndex CreateSearchIndex(this ProjectDto project, Func<long, IEnumerable<OrderDto>> getOrders, Func<long, IEnumerable<OrderTaskDto>> getTasks)
        {
            var orders = getOrders(project.Id.Value).ToList();
            var tasks = getTasks(project.Id.Value).ToList();
            return new ProjectSearchIndex
            {
                Id = project.Id.Value,
                FiscalSetupId = project.FiscalSetupId,
                IsDeactivated = project.IsDeactivated,
                Description = project.Description,
                Details = project.Details,
                ClosedDateDays = project.ClosedDateDays,
                IsClosed = project.ClosedDateDays.HasValue,
                Number = project.Number.ToString(),
                NumberSplits = project.Number.SplitNumberInParts(),
                PartnerName = project.PartnerName,
                PartnerAccountNumber = project.PartnerAccountNumber.ToString(),
                OrderNumber = string.Join(" ", orders.Select(o => o.OrderNumber)),
                OrderNumberSplits = string.Join(" ", orders.Select(o => o.OrderNumber.SplitNumberInParts())),
                OrderTaskNumberSplits = string.Join(" ", tasks.Select(t => t.Abbreviation.SplitStringInParts())),
                OrderTaskNumber = string.Join(" ", tasks.Select(t => t.Abbreviation))
            };
        }
        public static OrderTaskSearchIndex CreateSearchIndex(this OrderTaskDto task, Func<long, OrderDto> getOrder, Func<long, ProjectDto> getProject)
        {
            var order = getOrder(task.OrderId);
            var project = order.ProjectId.HasValue ? getProject(order.ProjectId.Value) : null;
            var deliveryAddress = order.DeliveryAddress ?? order.Address;
            return new OrderTaskSearchIndex
            {
                Id = task.Id.Value,
                FiscalSetupId = task.FiscalSetupId,
                Description = task.Description,
                Details = task.Details,
                ProjectNumber = order.ProjectNumber.ToString(),
                ProjectNumberSplits = order.ProjectNumber?.SplitNumberInParts(),
                OrderId = order.Id.Value,
                OrderNumber = order.OrderNumber.ToString(),
                OrderInternalNote = order.InternalNote,
                OrderNumberSplits = order.OrderNumber.SplitNumberInParts(),
                OrderTaskNumber = task.Abbreviation,
                OrderTaskNumberSplits = task.Abbreviation.SplitStringInParts(),
                DeliveryAttention = string.Empty,
                PartnerAccountNumber = $"{order.PartnerAccountNumber}",
                DeliveryCity = deliveryAddress.City,
                DeliveryCountryName = deliveryAddress.CountryName,
                DeliveryName = deliveryAddress.Name,
                DeliveryPlaceName = deliveryAddress.PlaceName,
                DeliveryStreet = deliveryAddress.Street,
                DeliveryZip = deliveryAddress.Zip,
                OrderAttention = string.Empty,
                OrderCity = order.Address.City,
                OrderCountryName = order.Address.CountryName,
                OrderName = order.Address.Name,
                OrderPlaceName = order.Address.PlaceName,
                OrderStreet = order.Address.Street,
                OrderZip = order.Address.Zip,
                IsDelivered = task.IsDelivered,
                IsInvoiced = task.IsInvoiced,
                ContextType = order.ContextType,
                IsDeactivated = task.IsDeactivated,
                ProjectDescription = order.ProjectDescription,
                ProjectDetails = project?.Details
            };
        }

        private static string SplitNumberInParts(this int number)
        {
            return number.ToString().SplitStringInParts();
        }
        private static string SplitStringInParts(this string numberString)
        {
            var parts = new string[numberString.Length];
            for (int i = 0; i < numberString.Length; i++)
            {
                parts[i] = numberString.Substring(numberString.Length - i - 1);
            }
            return string.Join(" ", parts);
        }

        public static OrderSearchIndex CreateSearchIndex(this OrderDto order, Func<long, IList<string>> getSupplierNumbers, Func<long, long, IList<object>> getOrderMetaData, Func<long, IList<string>> getOrderTaskDescriptions)
        {
            long orderId = order.Id.Value;
            return new OrderSearchIndex
            {
                Id = orderId,
                IsDeactivated = order.IsDeactivated,
                FiscalSetupId = order.FiscalSetupId,
                OrderNumberSplits = order.OrderNumber.SplitNumberInParts(),
                Name = order.Address.Name,
                PlaceName = order.Address.PlaceName,
                City = order.Address.City,
                Zip = order.Address.Zip,
                Street = order.Address.Street,
                CountryName = order.Address.CountryName,
                DeliveryName = order.DeliveryAddress?.Name,
                DeliveryPlaceName = order.DeliveryAddress?.PlaceName,
                DeliveryCity = order.DeliveryAddress?.City,
                DeliveryZip = order.DeliveryAddress?.Zip,
                DeliveryStreet = order.DeliveryAddress?.Street,
                DeliveryCountryName = order.DeliveryAddress?.CountryName,
                PartnerName = order.PartnerName,
                OurReference = order.OurReference,
                PartnerId = order.PartnerId,
                PartnerAccountNumber = $"{order.PartnerAccountNumber}",
                PartnerPhoneNumber = order.PartnerPhoneNumber,
                YourReference = order.YourReference,
                SupplierInvoiceNumbers = string.Join(" ", getSupplierNumbers(orderId)),
                ContextType = order.ContextType,
                IsFullyDelivered = order.Summary.IsFullyDelivered,
                IsFullyInvoiced = order.Summary.IsFullyInvoiced,
                OrderStatusId = order.OrderStatusId,
                ResponsibleId = order.ResponsibleId,
                InternalNote = order.InternalNote,
                MetaData = getOrderMetaData(order.FiscalSetupId, orderId),
                OrderTaskDescriptions = string.Join(" ", getOrderTaskDescriptions(orderId)),
                BearerId = order.BearerId,
                DepartmentId = order.DepartmentId,
                PurposeId = order.PurposeId
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

        public static PartnerSearchIndex CreateSearchIndex(this PartnerDto partner, Func<long, IList<PartnerTelephoneNumberDto>> getTelephoneNumbers, Func<long, IList<PartnerEmailContactDto>> getEmailContacts, Func<long, IEnumerable<OrderContextDto>> getOrderContexts, Func<long, long, IList<object>> getPartnerMetaData)
        {
            var invoiceEmails = getOrderContexts(partner.Id.Value).Select(oc => oc.InvoiceEmail);
            var emailContacts = getEmailContacts(partner.Id.Value);
            var emails = new HashSet<string>(invoiceEmails.Concat(emailContacts.Select(ec => ec.Email)));
            var emailNames = emailContacts.Select(ec => ec.Name).ToList();

            var partnerTelephoneNumbers = getTelephoneNumbers(partner.Id.Value);
            var telephoneNumbers = new HashSet<string>(partnerTelephoneNumbers.Select(pt => pt.Number));
            if (!string.IsNullOrWhiteSpace(partner.PhoneNumber))
                telephoneNumbers.Add(partner.PhoneNumber);
            var telephoneNumberNames = new HashSet<string>(partnerTelephoneNumbers.Where(ptn => !string.IsNullOrWhiteSpace(ptn.Name)).Select(ptn => ptn.Name));
            return new PartnerSearchIndex
            {
                Id = partner.Id.Value,
                Name = partner.Address.Name,
                AccountNumber = partner.AccountNumber.ToString(),
                PlaceName = partner.Address.PlaceName,
                City = partner.Address.City,
                Zip = partner.Address.Zip,
                Attention = partner.Attention,
                Street = partner.Address.Street,
                CountryName = partner.Address.CountryName,
                GLNNumber = partner.GLNNumber,
                URL = partner.URL,
                OrgNumber = partner.OrgNumber,
                FiscalSetupId = partner.FiscalSetupId,
                Tags = partner.Tags,
                Emails = emails.ToList(),
                EmailNames = emailNames,
                TelephoneNumbers = telephoneNumbers.ToList(),
                TelephoneNumberNames = telephoneNumberNames.ToList(),
                TelephoneNumbersStripped = telephoneNumbers.Select(tn => tn.StripTelephoneNumber()).ToList(),
                MetaData = getPartnerMetaData(partner.FiscalSetupId, partner.Id.Value)
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