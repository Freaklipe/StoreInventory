using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            // Stores
            btn_stores.Click += delegate 
            {
                ShowStoreView?.Invoke(this, EventArgs.Empty); 
            };

            // Products
            btn_products.Click += delegate
            {
                ShowProductView?.Invoke(this, EventArgs.Empty);
            };

            // Inventary
            btn_inventary.Click += delegate
            {
                ShowInventaryView?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler ShowStoreView;
        public event EventHandler ShowOwnerView;
        public event EventHandler ShowProductView;
        public event EventHandler ShowInventaryView;
    }
}
