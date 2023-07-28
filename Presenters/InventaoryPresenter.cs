using StoreInventory.Views;
using StoreInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventory.Presenters
{
    public class InventaoryPresenter
    {
        // Fields
        private IInventary inventaryView;
        private IInventoryRepository inventoryRepository;
        private BindingSource bindingSource;
        private IEnumerable<InventoryModel> list;

        // Constructor
        public InventaoryPresenter(IInventary view, IInventoryRepository repo)
        {
            this.bindingSource = new BindingSource();
            this.inventaryView = view;
            this.inventoryRepository = repo;

            // Subscribe event handler methods to view events
            this.inventaryView.SearchEvent += SearchEvent;
            this.inventaryView.EditEvent += EditEvent;
            this.inventaryView.SaveEvent += SaveEvent;

            // Set inventary bindind source
            this.inventaryView.SetInventoryListBindingSource(this.bindingSource);

            // Load Inventary
            LoadAllInventary();

            LoadAllCBStore();

            // Show view
            this.inventaryView.Show();
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            var model = new InventoryModel();
            model.Id = Int32.Parse(inventaryView.Id);
            model.CodProduct = inventaryView.Code;
            model.NameProduct = inventaryView.Name;
            model.IdStore = inventaryView.IdStore;
            model.NameStore = inventaryView.Store;
            model.Stock = Int32.Parse(inventaryView.Stock);
            model.Price = Int32.Parse(inventaryView.Price);


            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (inventaryView.IsEdit)
                {
                    inventoryRepository.Edit(model);
                    inventaryView.Message = "Edited successfuly";
                } else
                {
                    inventoryRepository.Add(model);
                    inventaryView.Message = "Added successfuly";
                }
                inventaryView.IsSuccessful = true;
                LoadAllInventary();
            } catch (Exception ex)
            {
                inventaryView.IsSuccessful = false;
                inventaryView.Message = ex.Message;
            }
        }

        private void EditEvent(object sender, EventArgs e)
        {
            var model = (InventoryModel)bindingSource.Current;
            inventaryView.Id = model.Id.ToString();
            inventaryView.Code = model.CodProduct;
            inventaryView.Name = model.NameProduct;
            //inventaryView.IdStore = model.IdStore.ToString();
            inventaryView.IdStore = "0";
            inventaryView.Store = model.NameStore;
            inventaryView.Stock = model.Stock.ToString();
            inventaryView.Price = model.Price.ToString();
            inventaryView.IsEdit = !model.NameStore.Equals("----");
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            string searchText = this.inventaryView.SearchValue;
            bool emptyValue = string.IsNullOrEmpty(searchText);
            if (!emptyValue) 
                list = inventoryRepository.GetByValue(searchText);
            else
                list = inventoryRepository.GetAll();
            bindingSource.DataSource = list;
        }

        private void LoadAllInventary()
        {
            list = inventoryRepository.GetAll();
            bindingSource.DataSource = list;
        }

        private IEnumerable<StoreModel> LoadAllCBStore()
        {
            IEnumerable <StoreModel> stores = inventoryRepository.GetAllStore();
            return stores; 
        }


    }
}
