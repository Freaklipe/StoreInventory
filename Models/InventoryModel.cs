using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory.Models
{
    public class InventoryModel
    {
        private int _id;
        private string _codProduct;
        private string _nameProduct;
        private string _idStore;
        private string _nameStore;
        private float _price;
        private int _stock;

        // Properties & Validate
        [DisplayName("ID")]
        [Required(ErrorMessage = "ID is required")]
        public int Id { get => _id; set => _id = value; }

        [DisplayName("Code Product")]
        [Required(ErrorMessage = "Code Product is required")]
        public string CodProduct { get => _codProduct; set => _codProduct = value; }

        [DisplayName("Product")]
        public string NameProduct { get => _nameProduct; set => _nameProduct = value; }

        [DisplayName("ID Store")]
        [Required(ErrorMessage = "ID Store is required")]
        public string IdStore { get => _idStore; set => _idStore = value; }

        [DisplayName("Store")]
        public string NameStore { get => _nameStore; set => _nameStore = value; }

        [DisplayName("Price")]
        [Required(ErrorMessage = "Price is required")]
        public float Price { get => _price; set => _price = value; }

        [DisplayName("Stock")]
        [Required(ErrorMessage = "Stock is required")]
        public int Stock { get => _stock; set => _stock = value; }
    }
}
