using StoreInventaory_2._0.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreInventaory_2._0.Views
{
    public partial class PricipalView : Form, IPrincipalView
    {

        private bool isSuccessful;
        private string message;
        private bool isEdit;
        private string category;

        private string product_id;
        private string product_code;
        private string product_name;
        private string store_id;
        private string store_name;
        private List<string> CBXID;
        private string inventory_id;

        public PricipalView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tbc_principal.TabPages.Remove(tbp_productDetail);
            tbc_principal.TabPages.Remove(tbp_storeDetail);
            tbc_principal.TabPages.Remove(tbp_inventoryDetail);
            btn_close.Click += delegate { this.Close(); };
            btn_return.Visible = false;
            btn_restore.Visible = false;

        }

        private void AssociateAndRaiseViewEvents()
        {
            // SearchEvent
            btn_search.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txt_search.KeyDown += (s, e) => {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // SaveEvent
            btnPD_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbc_principal.TabPages.Remove(tbp_productDetail);
                    tbc_principal.TabPages.Add(tbp_principal);
                }
                MessageBox.Show(Message);
            };

            btnSD_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbc_principal.TabPages.Remove(tbp_storeDetail);
                    tbc_principal.TabPages.Add(tbp_principal);
                }
                MessageBox.Show(Message);
            };

            btnID_save.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tbc_principal.TabPages.Remove(tbp_inventoryDetail);
                    tbc_principal.TabPages.Add(tbp_principal);
                }
                MessageBox.Show(Message);
            };

            // EditEvent
            btn_edit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tbc_principal.TabPages.Remove(tbp_principal);

                switch (Category)
                {
                    case "Product":
                        tbc_principal.TabPages.Add(tbp_productDetail);
                        tbp_productDetail.Text = "Edit Product";
                        break;
                    case "Store":
                        tbc_principal.TabPages.Add(tbp_storeDetail);
                        tbp_storeDetail.Text = "Edit Store";
                        break;
                    case "Inventory":
                        tbc_principal.TabPages.Add(tbp_inventoryDetail);
                        tbp_inventoryDetail.Text = "Edit Inventory";
                        break;
                }
            };

            // AddEvent
            btn_add.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tbc_principal.TabPages.Remove(tbp_principal);

                switch (Category)
                {
                    case "Product":
                        txtPD_code.ReadOnly = false;
                        tbc_principal.TabPages.Add(tbp_productDetail);
                        tbp_productDetail.Text = "Add new Product";
                        break;
                    case "Store":
                        lblSD_id.Visible = false;
                        txtSD_id.Visible = false;
                        tbc_principal.TabPages.Add(tbp_storeDetail);
                        tbp_storeDetail.Text = "Add new Store";
                        break;
                    case "Inventory":
                        tbc_principal.TabPages.Add(tbp_inventoryDetail);
                        tbp_inventoryDetail.Text = "Add new Inventory";
                        break;
                }

            };

            // Cancel Event
            btnPD_cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbc_principal.TabPages.Remove(tbp_productDetail);
                tbc_principal.TabPages.Add(tbp_principal);
            };

            btnSD_cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbc_principal.TabPages.Remove(tbp_storeDetail);
                tbc_principal.TabPages.Add(tbp_principal);
            };

            btnID_cancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tbc_principal.TabPages.Remove(tbp_inventoryDetail);
                tbc_principal.TabPages.Add(tbp_principal);
            };

            // StatusEvent Delete
            btn_delete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected "+Category+" ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    StatusEvent?.Invoke(this, EventArgs.Empty );
                    MessageBox.Show(Message);
                }
            };

            // StatusEvent Restore
            btn_restore.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected " + Category + " ?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    StatusEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };

            // ViewDeletedEvent
            btn_viewDeleted.Click += delegate
            {
                ViewDeletedEvent?.Invoke(this, EventArgs.Empty);
                btn_edit.Visible = false;
                btn_add.Visible = false;
                btn_delete.Visible = false;
                btn_viewDeleted.Visible = false;
                btn_restore.Visible = true;
                btn_return.Visible = true;
            };

            // return
            btn_return.Click += delegate
            {
                ReturnEvent?.Invoke(this, EventArgs.Empty);
                btn_edit.Visible = true;
                btn_add.Visible = true;
                btn_delete.Visible = true;
                btn_viewDeleted.Visible = true;
                btn_restore.Visible = false;
                btn_return.Visible = false;
            };
        }

        // Product properties
        public string Product_id { get => product_id; set => product_id = value; }
        public string Product_code 
        {
            get => product_code;
            // Esta condicion es necesaria para completar los campos visuales en detail Product y Inventory
            set
            {
                if (Category.Equals("Product"))
                    txtPD_code.Text = value;
                else 
                    txtID_code.Text = value;
                product_code = value;
            } 
        }
        public string Product_name 
        { 
            get => product_name;
            set
            {
                if (Category.Equals("Product"))
                    txtPD_name.Text = value;
                else
                    txtID_name.Text = value;
                product_name = value;
            } 
        }
        public string product_description { get => txtPD_description.Text; set => txtPD_description.Text = value; }

        // Store properties
        public string Store_id 
        { 
            get => store_id; 
            set
            {
                if (Category.Equals("Store"))
                    txtSD_id.Text = value;
                store_id = value;
            }
        }
        public string Store_name 
        { 
            //get => store_name; 
            get 
            {
                if (Category.Equals("Inventory"))
                    return CBXID_store.Text;
                else return store_name;
            }
            set
            {
                if (Category.Equals("Store"))
                {
                    txtSD_name.Text = value;
                    store_name = value;
                }
                else if (Category.Equals("Inventory"))
                {
                    CBXID_store.Text = value;
                    store_name = CBXID_store.Text;
                }
                   
                
            }
        }
        public string store_address { get => txtSD_address.Text; set => txtSD_address.Text = value; }
        public string store_description { get => txtSD_description.Text; set => txtSD_description.Text = value; }

        // Inventory properties
        public string Inventory_id { get => inventory_id; set => inventory_id = value; }
        public string inventory_stock { get => txtID_stock.Text; set => txtID_stock.Text = value; }
        public string inventory_price { get => txtID_price.Text; set => txtID_price.Text = value; }
        // General properties
        public string SearchValue { get => txt_search.Text; set => txt_search.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }
        public string Category { get => category; set => category = value; }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler StatusEvent;
        public event EventHandler ViewDeletedEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler ReturnEvent;

        public void StateView ()
        {
            lbl_title.Text = Category;
            if (Category.Equals("Inventory"))
            {
                btn_add.Visible = false;
                //btn_delete.Visible = false;
                btn_viewDeleted.Visible = false;
            } else
            {
                btn_add.Visible = true;
                btn_delete.Visible = true;
                btn_viewDeleted.Visible = true;
            }

        }

        public void SetListBindingSource(BindingSource list)
        {
            dgv_list.DataSource = list;
        }

        public void SetCBXIDStore(List<StoreModel> list)
        {
            CBXID_store.Items.Clear();
            foreach (StoreModel item in list)
            {
                CBXID_store.Items.Add(item.Id+" - "+item.Name);
            }
        }

        // Singleton patter (Open a single from instance)
        private static PricipalView instance;

        public static PricipalView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PricipalView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                // Esto es para evitar el problema de doble data al cambiar de categoria
                instance.Close();
                instance = new PricipalView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
                //
                instance.BringToFront();
            }
            return instance;
        }
    }
}
