using StoreInventaory_2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Data;

namespace StoreInventaory_2._0.Repositories
{
    public class PrincipalRepository : BaseRepository, IPrincipalRepository
    {
        private SqlConnection connection;

        public PrincipalRepository(string _connectionString) 
        {
            this.connectionString = _connectionString;
        }

        public SqlConnection GetSqlConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        public void Add(object obj, string arg)
        {
            string type = arg;
            string query = string.Empty;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = GetSqlConnection();

            if (type.Equals("Product"))
            {
                // Falta validar el tema del code que sea unico
                var product = (ProductModel)obj;
                query = "Insert into Product values(@code, @name, @description, 1)";
                cmd.CommandText = query;
                cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = product.Code;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = product.Description;
            } else if(type.Equals("Store"))
            {
                var store = (StoreModel)obj;
                query = "Insert into Store values(@name, @address, @description, 1)";
                cmd.CommandText = query;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = store.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = store.Address;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = store.Description;
            }

            cmd.ExecuteNonQuery();
        }

        public void Edit(object obj, string arg)
        {
            string type = arg;
            string query = string.Empty;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = GetSqlConnection();

            switch (type)
            {
                case "Product":
                    // Falta validar el tema del code que sea unico
                    var product = (ProductModel)obj;
                    query = @"Update Product
                            set _code=@code, _name=@name, _description=@description
                            Where _id=@id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = product.Id;
                    cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = product.Code;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = product.Name;
                    cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = product.Description;
                    break;

                case "Store":
                    var store = (StoreModel)obj;
                    query = @"Update Store
                            set _name=@name, _address=@address, _description=@description
                            Where _id = @id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = store.Id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = store.Name;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = store.Address;
                    cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = store.Description;
                    break;

                case "Inventory":
                    /* En la teoria y por el modelo el id store seria correcto, aun asi, falta 
                     * validar sau existencia antes de actualizar */
                    var inventory = (DetailModel)obj;
                    string[] idStore = inventory.NameStore.Split('-'); 
                    if(inventory.Id > -1) 
                    {
                        query = @"Update Detail
                            set _idStore=@idStore, _price=@price, _stock=@stock
                            where _id=@id";
                    } else
                    {
                        query = "Insert into Detail values( @idProduct, @idStore, @price, @stock)";
                    }

                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = inventory.Id;
                    cmd.Parameters.Add("@idStore", SqlDbType.Int).Value = idStore[0];
                    cmd.Parameters.Add("@idProduct", SqlDbType.Int).Value = inventory.IdProduct;
                    cmd.Parameters.Add("@price", SqlDbType.Int).Value = inventory.Price;
                    cmd.Parameters.Add("@stock", SqlDbType.Int).Value = inventory.Stock;

                    break;
            }

            cmd.ExecuteNonQuery();
        }

        public IEnumerable<object> GetAll(string [] arg)
        {
            string type = arg[0], status = arg[1];
            string query = string.Empty;
            var list = new List<object>();
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();

            switch (type)
            {
                case "Product":
                    query = @"Select * from Product
                            Where _status = @status
                            order by _id desc";
                    break;
                case "Store":
                    query = @"Select * from Store
                            Where _status = @status
                            order by _id desc";
                    break;
                case "Inventory":
                    query = @"select d._id as ID, p._id as IdProduct, p._code as Code, p._name as Name, s._id as IdStore, s._name as Store, d._stock as Stock, d._price as Price 
                            from Detail as d inner join Store s on d._idStore = s._id 
                            right join Product as p on d._idProduct = p._id 
                            where p._status = 1 
                            order by d._id desc";
                    break;
            }

            cmd.CommandText = query;
            cmd.Connection = GetSqlConnection();
            cmd.Parameters.Add("@status", SqlDbType.Char).Value = status;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (type)
                {
                    case "Product":
                        var productModel = new ProductModel();
                        productModel.Id = Int32.Parse(reader[0].ToString());
                        productModel.Code = reader[1].ToString();
                        productModel.Name = reader[2].ToString();
                        productModel.Description = reader[3].ToString();
                        list.Add(productModel);
                        break;
                    case "Store":
                        var storeModel = new StoreModel();
                        storeModel.Id = Int32.Parse(reader[0].ToString());
                        storeModel.Name = reader[1].ToString();
                        storeModel.Address = reader[2].ToString();
                        storeModel.Description = reader[3].ToString();
                        list.Add(storeModel);
                        break;
                    case "Inventory":
                        var detailModel = new DetailModel();
                        detailModel.Id = reader[0].ToString() == string.Empty ? -1 : Int32.Parse(reader[0].ToString());
                        detailModel.IdProduct = reader[1].ToString() == string.Empty ? -1 : Int32.Parse(reader[1].ToString());
                        detailModel.CodeProduct = reader[2].ToString();
                        detailModel.NameProduct = reader[3].ToString();
                        detailModel.IdStore = reader[4].ToString() == string.Empty ? -1 : Int32.Parse(reader[4].ToString());
                        detailModel.NameStore = reader[5].ToString() == string.Empty ? "" : reader[5].ToString();
                        detailModel.Stock = reader[6].ToString() == string.Empty ? 000 : Int32.Parse(reader[6].ToString());
                        detailModel.Price = reader[7].ToString() == string.Empty ? 000 : Int32.Parse(reader[7].ToString());
                        list.Add(detailModel);
                        break;
                }
            }
            reader.Close();

            return list;
        }

        public IEnumerable<object> GetByValue(string[] arg)
        {
            string type = arg[0], status = arg[1], search = arg[2];
            int id = int.TryParse(search, out _) ? Convert.ToInt32(search) : -1;
            string query = string.Empty;
            var list = new List<object>();
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();

            switch (type)
            {
                case "Product":
                    query = @"Select * from Product
                            Where _status = @status and 
                            _name like @search+'%' or 
                            _code like @search+'%' or 
                            _id = @id
                            order by _id desc";
                    break;
                case "Store":
                    query = @"Select * from Store
                            Where _status = @status and
                            _name like @search+'%' or
                            _id = @id
                            order by _id desc";
                    break;
                case "Inventory":
                    query = @"select d._id as ID, p._code as Code, p._name as Name, s._id as IdStore, s._name as Store, d._stock as Stock, d._price as Price 
                            from Detail as d inner join Store s on d._idStore = s._id 
                            right join Product as p on d._idProduct = p._id 
                            where p._status = @status and
                            p._code like @search+'%' or
                            p._name like @search+'%' or                            
                            s._name like @search+'%' or
                            d._price = @id or
                            d._id = @id
                            order by d._id desc";
                    break;
            }

            cmd.CommandText = query;
            cmd.Connection = GetSqlConnection();
            cmd.Parameters.Add("@status", SqlDbType.Char).Value = status;
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
            cmd.Parameters.Add("@search", SqlDbType.NVarChar).Value = search;
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                switch (type)
                {
                    case "Product":
                        var productModel = new ProductModel();
                        productModel.Id = Int32.Parse(reader[0].ToString());
                        productModel.Code = reader[1].ToString();
                        productModel.Name = reader[2].ToString();
                        productModel.Description = reader[3].ToString();
                        list.Add(productModel);
                        break;
                    case "Store":
                        var storeModel = new StoreModel();
                        storeModel.Id = Int32.Parse(reader[0].ToString());
                        storeModel.Name = reader[1].ToString();
                        storeModel.Address = reader[2].ToString();
                        storeModel.Description = reader[3].ToString();
                        list.Add(storeModel);
                        break;
                    case "Inventory":
                        var detailModel = new DetailModel();
                        detailModel.Id = reader[0].ToString() == string.Empty ? 000 : Int32.Parse(reader[0].ToString());
                        detailModel.CodeProduct = reader[1].ToString();
                        detailModel.NameProduct = reader[2].ToString();
                        detailModel.IdStore = reader[3].ToString() == string.Empty ? 000 : Int32.Parse(reader[3].ToString());
                        detailModel.NameStore = reader[4].ToString() == string.Empty ? "" : reader[4].ToString();
                        detailModel.Price = reader[6].ToString() == string.Empty ? 000 : Int32.Parse(reader[6].ToString());
                        detailModel.Stock = reader[5].ToString() == string.Empty ? 000 : Int32.Parse(reader[5].ToString());
                        list.Add(detailModel);
                        break;
                }
            }
            reader.Close();

            return list;
        }

        public void Status(object obj, string [] arg)
        {
            string type = arg[0], status = arg[1];
            string query = string.Empty;
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = GetSqlConnection();

            switch (type)
            {
                case "Product":
                    var product = (ProductModel)obj;
                    query = @"Update Product
                             set _status = @status
                             Where _id = @id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = product.Id;
                    break;

                case "Store":
                    var store = (StoreModel)obj;
                    query = @"Update Store
                             set _status = @status
                             Where _id = @id";
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = store.Id;
                    break;

                case "Inventory":
                    var inventory = (DetailModel)obj;
                    query = @"Delete Detail
                             where _id = @id";

                    cmd.CommandText = query;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = inventory.Id;

                    break;
            }
            cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
            cmd.ExecuteNonQuery();
        }

        public List<StoreModel> LoadComboBoxStoreName()
        {
            string query = "Select _id, _name from Store where _status=1";
            var list = new List<StoreModel>();
            SqlDataReader reader = null;
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = query;
            cmd.Connection = GetSqlConnection();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StoreModel model = new StoreModel();
                model.Id = Int32.Parse(reader[0].ToString());
                model.Name = reader[1].ToString();
                list.Add(model);
            }

            reader.Close();
            return list;
        }
    }
}
