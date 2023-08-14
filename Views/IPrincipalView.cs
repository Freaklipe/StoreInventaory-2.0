using StoreInventaory_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventaory_2._0.Views
{
    public interface IPrincipalView
    {
        // Fields & Properties
        string Product_id { get; set; }
        string Product_code { get; set; }
        string Product_name { get; set; }
        string product_description { get; set; }
        string Store_id { get; set; }
        string Store_name { get; set; }
        string store_address { get; set; }
        string store_description { get; set; }
        string Inventory_id { get; set; }
        //string inventory_nameProduct { get; set; }
        //string inventory_codeProduct { get; set; }
        //string inventory_storeId { get; set; }
        string inventory_stock { get; set; }
        string inventory_price { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }
        string Category { get; set; }

        //Events
        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler StatusEvent; //Delete = 0, Undelete = 1 >>> Delete/RestoreEvent();
        event EventHandler ViewDeletedEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler ReturnEvent;

        // Methods
        void SetListBindingSource(BindingSource list);

        void SetCBXIDStore(List<StoreModel> list);

        void StateView();

        void Show();
    }
}
