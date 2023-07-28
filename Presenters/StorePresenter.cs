using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreInventory.Models;
using StoreInventory.Views;
using System.Windows.Forms;

namespace StoreInventory.Presenters
{
    public class StorePresenter
    {
        // Fields
        private IStoreView _view;
        private IStoreRepository _repository;
        private BindingSource _bindingSource;
        private IEnumerable<StoreModel> _list;

        // Constructor
        public StorePresenter(IStoreView view, IStoreRepository repository)
        {
            this._bindingSource = new BindingSource();
            this._view = view;
            this._repository = repository;

            // Subscribe event handler methods to view events
            this._view.SearchEvent += Search;
            this._view.SearchDeletedEvent += SearchDeletedEvent;
            this._view.AddNewEvent += AddNewEvent;
            this._view.EditEvent += EditEvent;
            this._view.DeleteEvent += DeleteEvent;
            this._view.RestoreEvent += RestoreEvent;
            this._view.ViewDeletedEvent += ViewDeletedEvent;
            this._view.SaveEvent += SaveEvent;
            this._view.CancelEvent += CancelEvent;

            // Set store bindind source
            this._view.SetStoreListBindingSource(this._bindingSource);

            // Load store list
            LoadAllStoreList(1);

            // Show view
            this._view.Show();
        }

        // Methods
        private void Search(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchValue);
            if (!emptyValue)
                _list = _repository.GetByValue(this._view.SearchValue, 1);
            else _list = _repository.GetAll(1);
            _bindingSource.DataSource = _list;
        }

        private void SearchDeletedEvent(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this._view.SearchDeletedValue);
            if (!emptyValue)
                _list = _repository.GetByValue(this._view.SearchDeletedValue, 0);
            else _list = _repository.GetAll(0);
            _bindingSource.DataSource = _list;
        }

        private void AddNewEvent(object sender, EventArgs e)
        {
            _view.IsEdit = false;
        }

        private void EditEvent(object sender, EventArgs e)
        {
            var store = (StoreModel)_bindingSource.Current;
            _view.id = store.Id.ToString();
            _view.name= store.Name;
            _view.address = store.Address;
            _view.description = store.Description;
            _view.IsEdit = true;
        }

        private void DeleteEvent(object sender, EventArgs e)
        {
            try
            {
                var store = (StoreModel)_bindingSource.Current;
                _repository.Delete(store.Id);
                _view.IsSuccessful = true;
                _view.Message = "Store deleted successfully";
                LoadAllStoreList(1);
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not deleted store";
            }
        }

        private void RestoreEvent(object sender, EventArgs e)
        {
            try
            {
                var store = (StoreModel)_bindingSource.Current;
                _repository.Restore(store.Id);
                _view.IsSuccessful = true;
                _view.Message = "Store Restore successfully";
                LoadAllStoreList(0);
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = "An error ocurred, could not deleted store";
            }
        }

        private void ViewDeletedEvent(object sender, EventArgs e)
        {
            LoadAllStoreList(0);
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            var model = new StoreModel();
            model.Id = Convert.ToInt32(_view.id);
            model.Name = _view.name;
            model.Address = _view.address;
            model.Description = _view.description;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_view.IsEdit) //edit model
                {
                    _repository.Edit(model);
                    _view.Message = "Store edited successfuly";
                }
                else //Add new model
                {
                    _repository.Add(model);
                    _view.Message = "Store added successfuly";
                }
                _view.IsSuccessful = true;
                LoadAllStoreList(1);
                CleanViewFields();
            }
            catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            //_view.id = "0";
            _view.name = "";
            _view.address = "";
            _view.description = "";
        }

        private void LoadAllStoreList(byte arg)
        {
            _list = _repository.GetAll(arg);
            _bindingSource.DataSource = _list;
        }
    }
}
