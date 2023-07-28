using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory.Models
{
    public interface IInventoryRepository
    {
        void Add(InventoryModel inventoryModel);
        void Edit(InventoryModel inventoryModel);
        IEnumerable<InventoryModel> GetAll();
        IEnumerable<StoreModel> GetAllStore();
        IEnumerable<InventoryModel> GetByValue(string _search);
    }
}
