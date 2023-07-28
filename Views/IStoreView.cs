using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.Views
{
    public interface IStoreView
    {
        // Fields & Properties
        string id { get; set; }
        string name { get; set; }
        string address { get; set; }
        string description { get; set; }

        string SearchValue { get; set; }
        string SearchDeletedValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler SearchDeletedEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler RestoreEvent;
        event EventHandler ViewDeletedEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        //Methods
        void SetStoreListBindingSource(BindingSource storeList);
        void Show();//Optional
    }
}
