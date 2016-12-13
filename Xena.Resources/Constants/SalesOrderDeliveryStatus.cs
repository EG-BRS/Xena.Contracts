using System.Collections.Generic;

namespace Xena.Resources.Constants
{
    public static class SalesOrderDeliveryStatus
    {
        public static string[] All{ get { return new[] {NotApplicable, BarredForDelivery, NothingInStock, SomeInStock, AllInStock, Delivered, CannotDeliver}; }}
        public const string NotApplicable = "SalesOrderDeliveryStatus_NotApplicable";
        public const string BarredForDelivery = "SalesOrderDeliveryStatus_BarredForDelivery";
        public const string NothingInStock = "SalesOrderDeliveryStatus_NothingInStock";
        public const string SomeInStock = "SalesOrderDeliveryStatus_SomeInStock";
        public const string AllInStock = "SalesOrderDeliveryStatus_AllInStock";
        public const string Delivered = "SalesOrderDeliveryStatus_Delivered";
        public const string CannotDeliver = "SalesOrderDeliveryStatus_CannotDeliver";
    }

    public static class DeliveryStatusColor
    {
        public static Dictionary<string, string> All = new Dictionary<string, string>()
        {
            {SalesOrderDeliveryStatus.NotApplicable, White},
            {SalesOrderDeliveryStatus.BarredForDelivery, Black},
            {SalesOrderDeliveryStatus.NothingInStock, Red},
            {SalesOrderDeliveryStatus.SomeInStock, Yellow},
            {SalesOrderDeliveryStatus.AllInStock, Green},
            {SalesOrderDeliveryStatus.Delivered, Grey},
            {SalesOrderDeliveryStatus.CannotDeliver, Blue},
        }; 
        public static string White { get { return "#FFFFFF"; } }
        public static string Black { get { return "#000000"; } }
        public static string Red { get { return "#FF0000"; } }
        public static string Yellow { get { return "#FFFF00"; } }
        public static string Green { get { return "#40FF00"; } }
        public static string Grey { get { return "#a0a0a0"; } }
        public static string Blue { get { return "#000DFF"; } }
    }
}