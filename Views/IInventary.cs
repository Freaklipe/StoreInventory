using StoreInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.Views
{
    public interface IInventary
    {
        // Fields & Properties
        string Id { get; set; }
        string Code { get; set; }
        string Name { get; set; }
        string Stock { get; set; }
        string Price { get; set; }
        string IdStore { get; set; }
        string Store { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        // Events
        event EventHandler SearchEvent;
        event EventHandler EditEvent;
        event EventHandler SaveEvent;

        // Methods
        void SetInventoryListBindingSource(BindingSource InventoryList);
        void SetCB(IEnumerable<StoreModel> stores);

        void Show();// necesary
    }
}
