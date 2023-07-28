using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory.Models
{
    public interface IProductRepository
    {
        void Add(ProductModel productModel);
        void Edit(ProductModel productModel);
        void Delete_Restore(char _enable, string _cod);
        IEnumerable<ProductModel> GetAll(char _status);
        IEnumerable<ProductModel> GetByValue(string _search, char _status);
    }
}
