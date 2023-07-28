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
    public partial class ProductView : Form, IProductView
    {

        // Fields
        private bool isSuccessful;
        private string message;
        private bool isEdit;
        private BindingSource sourceList;

        // Constructor
        public ProductView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbc_product.TabPages.Remove(tbp_PD);
            tbc_product.TabPages.Remove(tbp_POS);
            btnProduct_close.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // AddNewEvent
            btnPIO_add.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbc_product.TabPages.Remove(tbp_PIO);
                tbc_product.TabPages.Add(tbp_PD);
                tbp_PD.Text = "Add new product";
            };

            // SaveEvent
            btnPD_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tbc_product.TabPages.Remove(tbp_PD);
                    tbc_product.TabPages.Add(tbp_PIO);
                }
                MessageBox.Show(Message);
            };

            // EditEvent
            btnPIO_edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbc_product.TabPages.Remove(tbp_PIO);
                tbc_product.TabPages.Add(tbp_PD);
                tbp_PD.Text = "Edit product";
            };

            // CancelEvent
            btnPD_cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbc_product.TabPages.Remove(tbp_PD);
                tbc_product.TabPages.Add(tbp_PIO);
            };

            // DeleteRestoreEvent -- Delete Product
            btnPIO_delete.Click += delegate
            {
                string msj = "Are you sure you want to delete the selected product?";
                var result = MessageBox.Show(msj, "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRestoreEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // SearchEvent >>> Search Product existing
            btnPIO_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtPIO_search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // SearchEvent >>> Search Product deleted
            btnPOS_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtPOS_search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // View Tab Deleted Product
            btnPIO_viewDeleted.Click += delegate
            {
                ViewDeletedEvent?.Invoke(this, EventArgs.Empty);
                tbc_product.TabPages.Remove(tbp_PIO);
                tbc_product.TabPages.Add(tbp_POS);
                dgvPOS_list.DataSource = sourceList;
            };

            // Return Tab Inicio
            btnPOS_return.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                tbc_product.TabPages.Remove(tbp_POS);
                tbc_product.TabPages.Add(tbp_PIO);
                txtPIO_search.Text = string.Empty;
            };

            // // DeleteRestoreEvent -- Restore Product
            btnPOS_restore.Click += delegate
            {
                string msj = "Are you sure you want to restore the selected product?";
                var result = MessageBox.Show(msj, "Warring", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteRestoreEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
        }

        public string cod 
        { 
            get => txtPD_code.Text; 
            set => txtPD_code.Text = value; 
        }
        public string name 
        { 
            get => txtPD_name.Text; 
            set => txtPD_name.Text = value; 
        }
        public string description 
        { 
            get => txtPD_description.Text; 
            set => txtPD_description.Text = value; 
        }

        public string SearchValue
        {
            get => txtPIO_search.Text;
            set => txtPIO_search.Text = value;
        }

        public string SearchDeletedValue
        {
            get => txtPOS_search.Text;
            set => txtPOS_search.Text = value;
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
        public void SetStoreListBindingSource(BindingSource storeList)
        {
            sourceList = storeList;
            dgvPIO_list.DataSource = sourceList;
        }

        // Events
        public event EventHandler AddNewEvent;
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SearchEvent;
        public event EventHandler DeleteRestoreEvent;
        public event EventHandler ViewDeletedEvent;
        
        

        // Singleton patter (Open a single from instance)
        private static ProductView instance;

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
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
    }
}
