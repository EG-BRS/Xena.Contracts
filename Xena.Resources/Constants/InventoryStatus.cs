using System.Collections.Generic;

namespace Xena.Resources.Constants
{
    public static class InventoryStatus
    {
        public const string InStock = "Xena_InventoryStatus_InStock";
        public const string InStockInOtherDepartment = "Xena_InventoryStatus_InStockOtherDepartment";
        public const string NotInStockButOrdered = "Xena_InventoryStatus_NotInStockButOrdered";
        public const string PartiallyInStock = "Xena_InventoryStatus_PartiallyInStock";
        public const string NotInStockSomeOrdered = "Xena_InventoryStatus_NotInStockSomeOrdered";
        public const string NotInStock = "Xena_InventoryStatus_NotInStock";

        public static IEnumerable<string> Sorted
        {
            get { return new[] {NotInStock, NotInStockSomeOrdered, PartiallyInStock, NotInStockButOrdered, InStockInOtherDepartment, InStock}; }
        }
    }
}