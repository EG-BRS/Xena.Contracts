using System.Collections.Generic;

namespace Xena.Contracts.Helpers
{
    public class ScannedBarcodeData
    {
        public IList<BarcodeData> BarCodes { get; set; }
        public long? TaskId { get; set; }
    }


    public class BarcodeData
    {
        public long Id { get; set; }
        public int Quantity { get; set; }
    }
}