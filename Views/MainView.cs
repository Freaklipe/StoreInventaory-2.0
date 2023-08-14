using System;
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
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();

            btn_product.Click += delegate
            {
                ShowPrincipalView?.Invoke(this, EventArgs.Empty);
            };

            btn_store.Click += delegate
            {
                ShowPrincipalView?.Invoke(this, EventArgs.Empty);
            };

            btn_inventory.Click += delegate
            {
                ShowPrincipalView?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler ShowPrincipalView;
    }
}
