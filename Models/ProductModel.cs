using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StoreInventory.Models
{
    public class ProductModel
    {
        private string cod;
        private string name;
        private string description;

        // Properties & Validate
        [DisplayName("Code")]
        [Required(ErrorMessage = "Code is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Code must be between 3 and 50 characters")]
        public string Cod { get => cod; set => cod = value; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get => name; set => name = value; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Description must be between 3 and 50 characters")]
        public string Description { get => description; set => description = value; }
        
    }
}
