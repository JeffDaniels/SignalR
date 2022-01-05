using AspNetSignalR.Models;
using AspNetSignalR.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSignalR
{
    [Route("api/[controller]")]
    [ApiController]
    public class Supplier : ControllerBase
    {
        private readonly InventoryDataStore _DataStore;

        public Supplier(InventoryDataStore dataStore)
        {
            _DataStore = dataStore;
        }

        [HttpPost]
        public string Post([FromBody] ItemRestock data)
        {
            bool result = _DataStore.StockItem(data.ProductId, data.Quantity);

            return result ? "Stock has been updated" : "Stock update failed";
        }
    }
}
