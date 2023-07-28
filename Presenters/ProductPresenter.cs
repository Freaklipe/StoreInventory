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
    public class ProductPresenter
    {
        // Fields
        private IProductView _productView;
        private IProductRepository _productRepository;
        private BindingSource _bindingSource;
        private IEnumerable<ProductModel> _list;

        // Constructor
        public ProductPresenter(IProductView view, IProductRepository repo)
        {
            this._bindingSource = new BindingSource();
            this._productView = view;
            this._productRepository = repo;

            // Subscribe event handler methods to view events
            this._productView.AddNewEvent += AddNewEvent;
            this._productView.EditEvent += EditEvent;
            this._productView.SaveEvent += SaveEvent;
            this._productView.DeleteRestoreEvent += DeleteRestoreEvent;
            this._productView.SearchEvent += SearchEvent;
            this._productView.ViewDeletedEvent += ViewDeletedEvent;


            // Set store bindind source
            this._productView.SetStoreListBindingSource(this._bindingSource);

            // Load product enabled = status 1
            LoadAllStoreList('1');

            // Show view
            this._productView.Show();
        }

        // Methods
        private void AddNewEvent(object sender, EventArgs e)
        {
            _productView.IsEdit = false;
        }

        private void EditEvent(object sender, EventArgs e)
        {
            var model = (ProductModel) _bindingSource.Current;
            _productView.cod = model.Cod;
            _productView.name = model.Name;
            _productView.description = model.Description;
            _productView.IsEdit = true;
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            var model = new ProductModel();
            model.Cod = _productView.cod;
            model.Name = _productView.name;
            model.Description = _productView.description;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_productView.IsEdit)
                {
                    _productRepository.Edit(model);
                    _productView.Message = "Product edited successfuly";
                } else
                {
                    _productRepository.Add(model);
                    _productView.Message = "Product added successfuly";

                }
                _productView.IsSuccessful = true;
                LoadAllStoreList('1');
                CleanViewFields();

            } catch (Exception ex)
            {
                _productView.IsSuccessful = false;
                _productView.Message = ex.Message;
            }
        }

        private void DeleteRestoreEvent(object sender, EventArgs e)
        {
            string button = (((ContainerControl)sender).ActiveControl).Text;
            char process;
            char loadList;
            string fail, ok;

            if (button.Equals("Delete"))
            {
                process = '0';
                loadList = '1';
                fail = "An error ocurred, could not deleted product";
                ok = "Product deleted successfully";
            } else
            {
                process = '1';
                loadList = '0';
                fail = "An error ocurred, could not restore product";
                ok = "Product restored successfully";
            }

            try
            {
                var product = (ProductModel)_bindingSource.Current;
                _productRepository.Delete_Restore(process, product.Cod);
                _productView.IsSuccessful = true;
                _productView.Message = ok;
                LoadAllStoreList(loadList);
            } catch
            {
                _productView.IsSuccessful = false;
                _productView.Message = fail;
            }
        }

        private void LoadAllStoreList(char _status)
        {
            _list = _productRepository.GetAll(_status);
            _bindingSource.DataSource = _list;
        }

        private void CleanViewFields()
        {
            _productView.cod = string.Empty;
            _productView.name = string.Empty;
            _productView.description = string.Empty;
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            char status = ((ContainerControl)sender).ActiveControl.Tag.ToString()[0];
            string searchText = status == '1' 
                ? this._productView.SearchValue : this._productView.SearchDeletedValue;
            bool emptyValue = string.IsNullOrEmpty(searchText);
            if (!emptyValue)
                _list = _productRepository.GetByValue(searchText, status);
            else
                _list = _productRepository.GetAll(status);
            _bindingSource.DataSource = _list;
        }

        private void ViewDeletedEvent(object sender, EventArgs e)
        {
            LoadAllStoreList('0');
        }
    }

}
