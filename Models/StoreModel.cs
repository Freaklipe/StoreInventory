using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreInventory.Models
{
    public class StoreModel
    {
        private int _id;
        private string _name;
        private string _address;
        private string _description;

        //Properties & Validations
        [DisplayName("Store ID")]
        public int Id { get => _id; set => _id = value; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get => _name; set => _name = value; }

        [DisplayName("Adress")]
        [Required(ErrorMessage = "adress is required")]
        [StringLength(50, ErrorMessage = "Adress not to exceed 100 characters")]
        public string Address { get => _address; set => _address = value; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Description not to exceed 250 characters")]
        public string Description { get => _description; set => _description = value; }
    }
}
