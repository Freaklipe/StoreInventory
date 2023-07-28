using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace StoreInventory.Views
{
    public partial class StoreView : Form, IStoreView
    {
        // Fields
        private bool isSuccessful;
        private string message;
        private bool isEdit;
        private BindingSource sourceList;

        // Constructor
        public StoreView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbc_store.TabPages.Remove(tbp_DeletedStore);
            tbc_store.TabPages.Remove(tbp_StoreDetail);
            btnStore_close.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            // Search -- Active
            btnAS_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtAS_search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // Search -- Deleted
            btnDS_search.Click += delegate { SearchDeletedEvent?.Invoke(this, EventArgs.Empty); };
            txtDS_search.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchDeletedEvent?.Invoke(this, EventArgs.Empty);
            };

            // Add new
            btnAS_add.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbc_store.TabPages.Remove(tbp_ActiveStore);
                tbc_store.TabPages.Add(tbp_StoreDetail);
                tbp_StoreDetail.Text = "Add new store";
            };

            // Edit
            btnAS_edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbc_store.TabPages.Remove(tbp_ActiveStore);
                tbc_store.TabPages.Add(tbp_StoreDetail);
                tbp_StoreDetail.Text = "Edit store";
            };

            // Save changes --- tbp
            btnSD_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tbc_store.TabPages.Remove(tbp_StoreDetail);
                    tbc_store.TabPages.Add(tbp_ActiveStore);
                }
                MessageBox.Show(Message);
            };

            // Cancel
            btnSD_cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbc_store.TabPages.Remove(tbp_StoreDetail);
                tbc_store.TabPages.Add(tbp_ActiveStore);
            };

            // Delete ---- Falta logica por el innerjoin
            btnAS_delete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected store?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // Restore
            btnDS_restore.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to restore the selected store?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    RestoreEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // View Deleted
            btnAS_viewDeleted.Click += delegate
            {
                ViewDeletedEvent?.Invoke(this, EventArgs.Empty);
                tbc_store.TabPages.Remove(tbp_ActiveStore);
                tbc_store.TabPages.Add(tbp_DeletedStore);
                dgvDS_list.DataSource = sourceList;
            };

            btnDS_return.Click += delegate
            {
                tbc_store.TabPages.Remove(tbp_DeletedStore);
                tbc_store.TabPages.Add(tbp_ActiveStore);
                txtAS_search.Text = string.Empty;
                SearchEvent?.Invoke(this, EventArgs.Empty);
            };
        }

        // Properties
        public string id 
        { 
            get => txtSD_id.Text;
            set => txtSD_id.Text = value;
        }

        public string name
        {
            get => txtSD_name.Text;
            set => txtSD_name.Text = value;
        }

        public string address
        {
            get => txtSD_address.Text;
            set => txtSD_address.Text = value;
        }

        public string description
        {
            get => txtSD_description.Text;
            set => txtSD_description.Text = value;
        }

        public string SearchValue
        {
            get => txtAS_search.Text;
            set => txtAS_search.Text = value;
        }

        public string SearchDeletedValue
        {
            get => txtDS_search.Text;
            set => txtDS_search.Text = value;
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

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler SearchDeletedEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler RestoreEvent;
        public event EventHandler ViewDeletedEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetStoreListBindingSource(BindingSource storeList)
        {
            sourceList = storeList;
            dgvAS_list.DataSource = storeList;
        }

        // Singleton patter (Open a single from instance)
        private static StoreView instance;
        public static StoreView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StoreView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            } else
            {
                if(instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
