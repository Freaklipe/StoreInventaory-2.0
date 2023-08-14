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
    public class MainPresenter
    {
        private IMainView _mainView;
        private readonly string sqlConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this._mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;
            this._mainView.ShowPrincipalView += ShowPrincipalView;
        }

        private void ShowPrincipalView(object sender, EventArgs e)
        {
            string arg = (((ContainerControl)sender).ActiveControl).Text;
            IPrincipalView view = PricipalView.GetInstance((MainView)_mainView);
            IPrincipalRepository repository = new PrincipalRepository(sqlConnectionString);
            new PrincipalPresenters(view, repository, arg);
        }
    }
}
