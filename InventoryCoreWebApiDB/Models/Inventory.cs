using System;
using System.Collections.Generic;

#nullable disable

namespace InventoryCoreWebApiDB.Models
{
    public partial class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
