using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventory.Views
{
    public interface IMainView
    {
        event EventHandler ShowStoreView;
        event EventHandler ShowOwnerView;
        event EventHandler ShowProductView;
        event EventHandler ShowInventaryView;
    }
}
