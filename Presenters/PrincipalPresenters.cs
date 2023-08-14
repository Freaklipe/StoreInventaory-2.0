using StoreInventaory_2._0.Models;
using StoreInventaory_2._0.Repositories;
using StoreInventaory_2._0.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventaory_2._0.Presenters
{
    public class PrincipalPresenters
    {
        // Fields
        private IPrincipalView _view;
        private IPrincipalRepository _repository;
        private BindingSource _bindingSource;
        private IEnumerable<object> list;
        private string _arg;
        private string _status;

        // Constructor
        public PrincipalPresenters(IPrincipalView view, IPrincipalRepository repository, string arg )
        {
            this._view = view;
            this._view.Category = arg;
            this._repository = repository;
            this._bindingSource = new BindingSource();
            this._arg = arg;
            this._status = "1";

            // Subscribe event handler methods to view events
            this._view.SearchEvent += SearchEvent;
            this._view.EditEvent += EditEvent;
            this._view.SaveEvent += SaveEvent;
            this._view.CancelEvent += CancelEvent;
            this._view.StatusEvent += StatusEvent;
            this._view.ViewDeletedEvent += ViewDeletedEvent;
            this._view.ReturnEvent += ReturnEvent;

            // Set inventary bindind source
            this._view.SetListBindingSource(this._bindingSource);

            // Load List
            LoadAllInventary();

            this._view.StateView();

            // Show view
            this._view.Show();
        }

        private void ReturnEvent(object sender, EventArgs e)
        {
            this._status = "1";
            LoadAllInventary();
        }

        private void ViewDeletedEvent(object sender, EventArgs e)
        {
            this._status = "0";
            LoadAllInventary();
        }

        private void StatusEvent(object sender, EventArgs e)
        {
            string status = (((ContainerControl)sender).ActiveControl).Tag.ToString();
            string ok_msj = status.Equals("0") ?
                            string.Concat(_arg, ": deleted successfully"):
                            string.Concat(_arg, ": retore successfully");
            string err_msj = status.Equals("0") ?
                             string.Concat("An error ocurred, could not deleted ", _arg):
                             string.Concat("An error ocurred, could not restore ", _arg);

            try
            {
                string[] arg = { this._arg, status };
                var model = _bindingSource.Current;
                _repository.Status(model, arg);
                _view.IsSuccessful = true;
                _view.Message = ok_msj;
                LoadAllInventary();
            } catch
            {
                _view.IsSuccessful = false;
                _view.Message = err_msj;
            }
        }

        private void CancelEvent(object sender, EventArgs e)
        {
            ClearViewFields();
        }

        private void SaveEvent(object sender, EventArgs e)
        {
            var model = new object();

            switch (this._arg)
            {
                case "Product":
                    var product = new ProductModel();
                    product.Id = Int32.Parse(this._view.Product_id);
                    product.Code = this._view.Product_code;
                    product.Name = this._view.Product_name;
                    product.Description = this._view.product_description;
                    model = product;
                    break;

                case "Store":
                    var store = new StoreModel();
                    store.Id = Int32.Parse(this._view.Store_id);
                    store.Name = this._view.Store_name;
                    store.Address = this._view.store_address;
                    store.Description = this._view.store_description;
                    model = store;
                    break;
                    // solo falta trabajar el idstore para el edit / update
                case "Inventory":
                    var inventory = new DetailModel();
                    inventory.Id = Int32.Parse(this._view.Inventory_id);
                    inventory.IdProduct = Int32.Parse(this._view.Product_id);
                    inventory.CodeProduct = this._view.Product_code;
                    inventory.NameProduct = this._view.Product_name;
                    inventory.IdStore = Int32.Parse(this._view.Store_id);
                    inventory.NameStore = this._view.Store_name;
                    inventory.Stock = Int32.Parse(this._view.inventory_stock);
                    inventory.Price = Int32.Parse(this._view.inventory_price);
                    model = inventory;
                    break;
            }

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (_view.IsEdit)
                {
                    _repository.Edit(model, this._arg);
                    _view.Message = "Edited successfuly";
                } else
                {
                    _repository.Add(model, this._arg);
                    _view.Message = "Added successfuly";
                }
                _view.IsSuccessful = true;
                LoadAllInventary();
                ClearViewFields();
            } catch (Exception ex)
            {
                _view.IsSuccessful = false;
                _view.Message = ex.Message;
            }

        }

        private void EditEvent(object sender, EventArgs e)
        {

            switch (this._arg)
            {
                case "Product":
                    var product = (ProductModel)_bindingSource.Current;
                    _view.Product_id = product.Id.ToString();
                    _view.Product_code = product.Code.ToString();
                    _view.Product_name = product.Name.ToString();
                    _view.product_description = product.Description.ToString();
                    _view.IsEdit = true;
                    break;

                case "Store":
                    var store = (StoreModel) _bindingSource.Current;
                    _view.Store_id = store.Id.ToString();
                    _view.Store_name = store.Name.ToString();
                    _view.store_address = store.Address.ToString();
                    _view.store_description = store.Description.ToString();
                    _view.IsEdit = true;
                    break;

                case "Inventory":
                    this._view.SetCBXIDStore(_repository.LoadComboBoxStoreName());
                    var inventory = (DetailModel)_bindingSource.Current;
                    _view.Inventory_id = inventory.Id.ToString();
                    _view.Product_id = inventory.IdProduct.ToString();
                    _view.Product_code = inventory.CodeProduct.ToString();
                    _view.Product_name = inventory.NameProduct.ToString();
                    _view.Store_id = inventory.IdStore.ToString();
                    _view.Store_name = inventory.IdStore.ToString()+" - "+inventory.NameStore.ToString();
                    _view.inventory_stock = inventory.Stock.ToString();
                    _view.inventory_price = inventory.Price.ToString();
                    _view.IsEdit = true;
                    break;
            }
        }

        private void SearchEvent(object sender, EventArgs e)
        {
            string searchText = this._view.SearchValue;
            string[] arg = { this._arg, this._status, searchText };
            bool emptyValue = string.IsNullOrEmpty(searchText);
            if (emptyValue)
                list = _repository.GetAll(arg);
            else
                list = _repository.GetByValue(arg);
            _bindingSource.DataSource = list;
        }

        private void LoadAllInventary()
        {
            string [] arg = { this._arg, this._status };
            list = _repository.GetAll(arg);
            _bindingSource.DataSource = list;
        }

        private void ClearViewFields()
        {
            _view.Product_id = string.Empty;
            _view.Product_code = string.Empty;
            _view.Product_name = string.Empty;
            _view.product_description = string.Empty;

            _view.Store_id = string.Empty;
            _view.Store_name = string.Empty;
            _view.store_address = string.Empty;
            _view.store_description = string.Empty;

            _view.Inventory_id = string.Empty;
            _view.inventory_stock = string.Empty;
            _view.inventory_price = string.Empty;
        }

    }
}
