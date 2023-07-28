using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory.Models
{
    public interface IStoreRepository
    {
        void Add(StoreModel storeModel);
        void Edit(StoreModel storeModel);
        void Delete(int id);
        void Restore(int id);
        IEnumerable<StoreModel> GetAll(byte value);
        //Search
        IEnumerable<StoreModel> GetByValue(string value, byte arg);
    }
}
