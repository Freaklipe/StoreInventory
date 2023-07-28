using StoreInventory.Models;
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
    public partial class InventaryView : Form, IInventary
    {
        private string id;
        private string idStore;
        private bool isSuccessful;
        private string message;
        private bool isEdit;
        private BindingSource sourceList;


        public InventaryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbc_inventary.TabPages.Remove(tbp_ID);
            btnInventary_close.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // SearchEvent
            btnI_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtI_search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) 
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // EditEvent
            btnI_edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbc_inventary.TabPages.Remove(tbp_I);
                tbc_inventary.TabPages.Add(tbp_ID);

                CBXID_store.Items.Add("Central");
                CBXID_store.Items.Add("Santiago");
                CBXID_store.Items.Add("Maipu");
                CBXID_store.Items.Add("La Florida");
                CBXID_store.Items.Add("Serena");
                CBXID_store.Items.Add("Temuco");
                tbp_ID.Text = "Edit Register";
            };

            // CancelEvent
            btnID_cancel.Click += delegate
            {
                tbc_inventary.TabPages.Remove(tbp_ID);
                tbc_inventary.TabPages.Add(tbp_I);
            };

            // SaveEvent
            btnID_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbc_inventary.TabPages.Remove(tbp_ID);
                    tbc_inventary.TabPages.Add(tbp_I);
                }
                MessageBox.Show(Message);
            };

        }

        public string Code 
        { 
            get => txtID_code.Text;
            set => txtID_code.Text = value; 
        }
        public string Name
        {
            get => txtID_name.Text;
            set => txtID_name.Text = value;
        }

        public string Store
        {
            get => CBXID_store.Text;
            set => CBXID_store.Text = value;
        }

        public string Stock 
        { 
            get => txtID_stock.Text; 
            set => txtID_stock.Text = value; 
        }
        public string Price 
        {
            get => txtID_price.Text;
            set => txtID_price.Text = value;
        }

        public string SearchValue 
        {
            get => txtI_search.Text;
            set => txtI_search.Text = value;
        }
        public bool IsEdit 
        {
            get => isEdit;
            set => isEdit = value;
        }
        public bool IsSuccessful 
        {
            get => isSuccessful;
            set => isSuccessful = value;
        }
        public string Message 
        {
            get => message;
            set => message = value;
        }
        public string Id 
        {
            get => id;
            set => id = value;
        }
        public string IdStore 
        {
            get => idStore;
            set => idStore = value;
        }

        public event EventHandler SearchEvent;
        public event EventHandler EditEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetInventoryListBindingSource(BindingSource InventoryList)
        {
            sourceList = InventoryList ;
            dgvI_list.DataSource = sourceList;
        }

        // Singleton patter (Open a single from instance)
        private static InventaryView instance;

        public static InventaryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new InventaryView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }

        public void SetCB(IEnumerable<StoreModel> stores)
        {
            CBXID_store.Items.Add(stores);
        }
    }
}
