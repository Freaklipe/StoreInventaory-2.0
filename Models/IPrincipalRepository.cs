using StoreInventaory_2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreInventaory_2._0.Repositories
{
    public interface IPrincipalRepository
    {
        void Add(object obj, string arg);
        void Edit(object obj, string arg);
        void Status(object obj, string [] arg);
        IEnumerable<object> GetAll(string[] arg);
        IEnumerable<object> GetByValue(string[] var);

        List<StoreModel> LoadComboBoxStoreName();
    }
}
