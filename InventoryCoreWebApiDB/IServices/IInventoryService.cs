using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InventoryCoreWebApiDB.Models;

namespace InventoryCoreWebApiDB.IServices
{
   public interface IInventoryService
    {

        IEnumerable<Inventory> GetInventory();
        Inventory GetInventoryById(int id);
        Inventory AddInventory(Inventory inventory);
        Inventory UpdateInventory(Inventory inventory);
        Inventory DeleteInventory(int id);
    }
}
