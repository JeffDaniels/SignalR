using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSignalR.Models
{
    public class ItemRestock
    {
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
