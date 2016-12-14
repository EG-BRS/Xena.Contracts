namespace Xena.Contracts.Helpers
{
//    public class PaymentSuccessData
//    {
//        public string OrderId { get; set; }
//        public string UniqueOId { get; set; }
//        public string PayType { get; set; }
//        public string StatusCode { get; set; }
//    }

    public class PaymentSuccessData
    {
        public string OrderId { get; set; } 
        public int Paymenttype { get; set; }
        public string Hash { get; set; }
    }
}