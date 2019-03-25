namespace Xena.Contracts.ApiRoutes
{
    public class PaymentMeansRoutes : BaseRoutes
    {
        /// <summary>"Fiscal/{fiscalId}/PaymentMeans"</summary>
        public const string Base = "Fiscal/{fiscalId}/PaymentMeans";

        /// <summary>"PaymentMeansType"</summary>
        public const string GetPaymentMeansTypeList = "PaymentMeansType";

        /// <summary>"PaymentMeansType/Export"</summary>
        public const string GetPaymentMeansTypeForExportList = "PaymentMeansType/Export";

        /// <summary>"PaymentMeansTypeData/Supplier"</summary>
        public const string GetPaymentMeansTypeDataForSupplierList = "PaymentMeansTypeData/Supplier";

        /// <summary>"PaymentMeansType/Supplier/Select"</summary>
        public const string GetSupplierPaymentMeansTypeList = "PaymentMeansType/Supplier/Select";


    }
}