using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using InventoryCoreWebApiDB.IServices;
using InventoryCoreWebApiDB.Models;
using InventoryCoreWebApiDB.Services;
using Microsoft.AspNetCore.Mvc.NewtonsoftJson;
namespace InventoryCoreWebApiDB.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryService inventoryService;

        public InventoryController(IInventoryService inventory)
        {
            inventoryService = inventory;
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Inventory/GetInventory")]
        public IEnumerable<Inventory> GetInventory()
        {
            return inventoryService.GetInventory();
        }
        [HttpPost]
        [Route("[action]")]
        [Route("api/Inventory/AddInventory")]
        public Inventory AddInventory([FromBody]Inventory inventory)
        {
            return inventoryService.AddInventory(inventory);
        }
        [HttpPut]
        [Route("[action]")]
        [Route("api/Inventory/EditInventory")]
        public Inventory EditInventory([FromBody]Inventory inventory)
        {
            return inventoryService.UpdateInventory(inventory);
        }
        [HttpDelete]
        [Route("[action]")]
        [Route("api/Inventory/DeleteInventory")]
        public Inventory DeleteInventory(int id)
        {
            return inventoryService.DeleteInventory(id);
        }
        [HttpGet]
        [Route("[action]")]
        [Route("api/Inventory/GetInventoryId")]
        public Inventory GetInventoryId(int id)
        {
            return inventoryService.GetInventoryById(id);
        }
    }
}