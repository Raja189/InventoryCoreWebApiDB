using Microsoft.EntityFrameworkCore;  
using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Threading.Tasks;  
using InventoryCoreWebApiDB.IServices;  
using InventoryCoreWebApiDB.Models;  
namespace InventoryCoreWebApiDB.Services
{
    public class InventoryService : IInventoryService
    {
        InventoryWebApiDBContext dbContext;
        public InventoryService(InventoryWebApiDBContext _db)
        {
            dbContext = _db;
        }
        public IEnumerable<Inventory> GetInventory()
        {
            var Inventory = dbContext.Inventories.ToList();
            return Inventory;
        }
        public Inventory AddInventory(Inventory Inventory)
        {
            if (Inventory != null)
            {
                dbContext.Inventories.Add(Inventory);
                dbContext.SaveChanges();
                return Inventory;
            }
            return null;
        }
        public Inventory UpdateInventory(Inventory Inventory)
        {
            dbContext.Entry(Inventory).State = EntityState.Modified;
            dbContext.SaveChanges();
            return Inventory;
        }
        public Inventory DeleteInventory(int id)
        {
            var Inventory = dbContext.Inventories.FirstOrDefault(x => x.InventoryId == id);
            dbContext.Entry(Inventory).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return Inventory;
        }
        public Inventory GetInventoryById(int id)
        {
            var Inventory = dbContext.Inventories.FirstOrDefault(x => x.InventoryId == id);
            return Inventory;
        }
    }
}