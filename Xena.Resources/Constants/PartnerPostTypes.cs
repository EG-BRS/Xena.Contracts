using System.Linq;

namespace Xena.Resources.Constants
{
    public static class SubscriptionInvoiceStates
    {
        public static string Open { get { return "SubscriptionInvoiceStates_Open"; } }
        public static string Invoiced { get { return "SubscriptionInvoiceStates_Invoiced"; } }
        public static string Paid { get { return "SubscriptionInvoiceStates_Paid"; } }
    }
    public static class PartnerPostTypes
    {
        public static string CustomerPrimo { get { return "PartnerPostType_CustomerPrimo"; } }
        public static string CustomerInvoice { get { return "PartnerPostType_CustomerInvoice"; } }
        public static string CustomerCreditNote { get { return "PartnerPostType_CustomerCreditNote"; } }
        public static string CustomerInterest { get { return "PartnerPostType_CustomerInterest"; } }
        public static string CustomerPayment { get { return "PartnerPostType_CustomerPayment"; } }
        public static string CustomerAdjustment { get { return "PartnerPostType_CustomerAdjustment"; } }
        public static string SupplierPrimo { get { return "PartnerPostType_SupplierPrimo"; } }
        public static string SupplierInvoice { get { return "PartnerPostType_SupplierInvoice"; } }
        public static string SupplierCreditNote { get { return "PartnerPostType_SupplierCreditNote"; } }
        public static string SupplierInterest { get { return "PartnerPostType_SupplierInterest"; } }
        public static string SupplierPayment { get { return "PartnerPostType_SupplierPayment"; } }
        public static string SupplierAdjustment { get { return "PartnerPostType_SupplierAdjustment"; } }
        public static string[] CustomerRelated { get { return new[] { CustomerPrimo, CustomerInterest, CustomerInvoice, CustomerCreditNote, CustomerPayment, CustomerAdjustment }; } }
        public static string[] SupplierRelated { get { return new[] { SupplierPrimo, SupplierInterest, SupplierInvoice, SupplierCreditNote, SupplierPayment, SupplierAdjustment }; } }
        public static string[] All { get { return CustomerRelated.Concat(SupplierRelated).ToArray(); } }

        public static string[] GetByContextType(string contextType)
        {
            return contextType == ContextTypes.Customer ? CustomerRelated : SupplierRelated;
        }
    }
}