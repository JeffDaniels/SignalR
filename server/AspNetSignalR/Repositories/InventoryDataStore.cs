using AspNetSignalR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetSignalR.Repositories
{
    public class InventoryDataStore
    {
        public InventoryDataStore()
        {
            Inventory = new List<SaleItem>();
            InitializeInventory();
        }

        public List<SaleItem> Inventory { get; set; }

        public event EventHandler InventoryChanged;

        private void InitializeInventory()
        {
            Inventory = new List<SaleItem>();
            Inventory.Add(new SaleItem { 
                ProductId = "001", 
                ProductName = "Apple", 
                Price = 4.25, 
                Available = 3,
                ReorderQty = 1,
                RestockQty = 3
            });
            Inventory.Add(new SaleItem { 
                ProductId = "002", 
                ProductName = "Orange",
                Price = 9.75, 
                Available = 4,
                ReorderQty = 2,
                RestockQty = 5
            });
            Inventory.Add(new SaleItem { 
                ProductId = "003", 
                ProductName = "Banana", 
                Price = 2.50, 
                Available = 12,
                ReorderQty = 5,
                RestockQty = 10
            });
        }

        public void SellItem(string productId)
        {
            var item = Inventory
                        .Find(p => p.ProductId.Equals(productId, StringComparison.InvariantCultureIgnoreCase));

            if (item != null && item.Available > 0)
            {
                item.Available--;
            }

            InventoryChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool StockItem(string productId, int qty)
        {
            if(qty < 0 || qty > 100)
            {
                return false;
            }

            var item = Inventory
                        .Find(p => p.ProductId.Equals(productId, StringComparison.InvariantCultureIgnoreCase));

            if(item != null)
            {
                item.Available += qty;
            }

            InventoryChanged?.Invoke(this, EventArgs.Empty);

            return true;
        }

        public void IssuePurchaseRequest(string productId)
        {
            var item = Inventory
                        .Find(p => p.ProductId.Equals(productId, StringComparison.InvariantCultureIgnoreCase));

            if (item != null)
            {
                item.Available += item.RestockQty;
            }

            InventoryChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
