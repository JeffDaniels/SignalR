using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSignalR.Models
{
    public class SaleItem
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }

        public int Available { get; set; }
        public double Price { get; set; }

        public int BackorderQty { get; set; }
        public int ReorderQty { get; set; }
        public int RestockQty { get; set; }
    }
}
