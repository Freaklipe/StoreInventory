using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreInventory.Models;
using StoreInventory.Repositories;
using StoreInventory.Views;

namespace StoreInventory.Presenters
{
    internal class MainPresenter
    {
        private IMainView _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this._mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.ShowStoreView += ShowStoreView;
            this._mainView.ShowProductView += ShowProductView;
            this._mainView.ShowInventaryView += ShowInventaryView;
        }
       
        // Store
        private void ShowStoreView(object sender, EventArgs e)
        {
            IStoreView view = StoreView.GetInstance((MainView)_mainView);
            IStoreRepository repository = new StoreRepository(sqlConnectionString);
            new StorePresenter(view, repository);
        }

        // Product
        private void ShowProductView(object sender, EventArgs e)
        {
            IProductView view = ProductView.GetInstance((MainView)_mainView);
            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
        }

        // Inventary
        private void ShowInventaryView(object sender, EventArgs e)
        {
            IInventary view = InventaryView.GetInstance((MainView)_mainView);
            IInventoryRepository repository = new InventaryRepository(sqlConnectionString);
            new InventaoryPresenter(view, repository);
        }
    }
}
