using System.Collections.Generic;
using System.Linq;
using Xena.Resources;
using Xena.Resources.Constants;

namespace Xena.Contracts.Domain
{
    public class OrderDto : EntityDto
    {
        private string _orderDeliveryStatus;
        private string _internalNote;
        private OrderSummaryDto _summary;
        public long? PartnerId { get; set; }
        public string OurReference { get; set; }
        public string YourReference { get; set; }
        public string ContextType { get; set; }
        public AddressDto Address { get; set; }
        public AddressDto DeliveryAddress { get; set; }
        public string DeliveryNote { get; set; }
        public int OrderNumber { get; set; }
        public int? DateDays { get; set; }
        public int? DeliveryDateDays { get; set; }
        public string CurrencyAbbreviation { get; set; }
        public long? OfferReportLayoutId { get; set; }
        public long? DeliveryReportLayoutId { get; set; }
        public long? InvoiceReportLayoutId { get; set; }
        public long? ConfirmationReportLayoutId { get; set; }
        public string OfferReportLayoutName { get; set; }
        public string DeliveryReportLayoutName { get; set; }
        public string InvoiceReportLayoutName { get; set; }
        public string ConfirmationReportLayoutName { get; set; }

        public string InternalNote
        {
            get { return _internalNote??string.Empty; }
            set { _internalNote = value; }
        }

        public TermsOfPaymentDto TermsOfPayment { get; set; }
        public string Culture { get; set; }
        public long? ProjectId { get; set; }
        public long? ResponsibleId { get; set; }
        public string ResponsibleName { get; set; }
        public string InvoiceEmail { get; set; }
        public string PartnerAccountNumber { get; set; }
        public string PartnerName { get; set; }
        public string PartnerNote { get; set; }
        public string PartnerPhoneNumber { get; set; }
        public string PartnerType { get; set; }

        public OrderSummaryDto Summary
        {
            get { return _summary??new OrderSummaryDto(); }
            set { _summary = value; }
        }

        public IList<int> OrderInvoiceNumbers { get; set; }
        public long? DepartmentId { get; set; }
        public string DepartmentDescription { get; set; }
        public long? BearerId { get; set; }
        public string BearerDescription { get; set; }
        public long? PurposeId { get; set; }
        public string PurposeDescription { get; set; }
        public bool IsHeaderReadOnly { get; set; }
        public long? OrderStatusId { get; set; }
        public string OrderStatusName { get; set; }
        public string OrderStatusColor { get; set; }
        public string ProjectDescription { get; set; }
        public int? ProjectNumber { get; set; }

        public string OrderDeliveryStatus
        {
            get { return _orderDeliveryStatus ?? SalesOrderDeliveryStatus.NotApplicable; }
            set { _orderDeliveryStatus = value; }
        }
        public string CultureDisplayName => string.IsNullOrEmpty(Culture) ? string.Empty : Culture.GetLocalizedCultureName();

    }
}