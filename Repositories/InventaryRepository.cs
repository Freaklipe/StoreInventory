using StoreInventory.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Dynamic;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace StoreInventory.Repositories
{
    public class InventaryRepository : BaseRepository, IInventoryRepository
    {
        private SqlConnection connection;
        private string query;
        public InventaryRepository( string _connectionString) 
        {
            this.connectionString = _connectionString;
        }

        public SqlConnection GetConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
            }
            return connection;
        }

        private int Store(string name)
        {
            int store = 0;
            switch (name)
            {
                case "Central":
                    store = 0;
                    break;
                case "Santiago":
                    store = 1;
                    break;
                case "Maipu":
                    store = 2;
                    break;
                case "La Florida":
                    store = 3;
                    break;
                case "Serena":
                    store = 4;
                    break;
                case "Temuco":
                    store = 5;
                    break;
            }

            return store;
        }

        public void Add(InventoryModel inventoryModel)
        {
            query = @"insert into Detail
                     values (@codeProduct, @idStore, @price, @stock)";
            int idStore = Store(inventoryModel.NameStore);
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@codeProduct", SqlDbType.NVarChar).Value = inventoryModel.CodProduct;
                cmd.Parameters.Add("@idStore", SqlDbType.Int).Value = idStore;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = inventoryModel.Price;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = inventoryModel.Stock;
                cmd.ExecuteNonQuery();
            }
        }

        public void Edit(InventoryModel inventoryModel)
        {
            query = @"update Detail 
                    set _idStore=@store, _stock=@stock, _price=@price
                    where _id=@id";
            int idStore = Store(inventoryModel.NameStore);
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = inventoryModel.Id;
                cmd.Parameters.Add("@store", SqlDbType.NVarChar).Value = idStore;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = inventoryModel.Stock;
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = inventoryModel.Price;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<InventoryModel> GetAll()
        {

            var list = new List<InventoryModel>();
            query = @"select d._id as ID, p._cod as Code, p._name as Name, s._id as IdStore, s._name as Store, d._stock as Stock, d._price as Price from 
                    Detail as d inner join Store s 
                    on d._idStore = s._id
                    right join Product as p 
                    on d._codProduct = p._cod
                    where p._status = @status
                    order by d._id desc";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = GetConnection();
            command.Parameters.Add("@status", SqlDbType.Char).Value = '1';//solo como prueba
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                var inventoryModel = new InventoryModel();
                inventoryModel.Id = reader[0].ToString() == string.Empty ? 000 : Int32.Parse(reader[0].ToString());
                inventoryModel.CodProduct = reader[1].ToString() == string.Empty ? "----" : reader[1].ToString();
                inventoryModel.NameProduct = reader[2].ToString();
                inventoryModel.IdStore = reader[3].ToString() == string.Empty ? "" : reader[3].ToString();
                inventoryModel.NameStore = reader[4].ToString() == string.Empty ? "----" : reader[4].ToString();
                inventoryModel.Stock = reader[5].ToString() == string.Empty ? 000 : Int32.Parse(reader[5].ToString());
                inventoryModel.Price = reader[6].ToString() == string.Empty ? 000 : float.Parse(reader[6].ToString());
                list.Add(inventoryModel);
            }
            reader.Close();
            //GetConnection().Close();

            return list;
        }

        public IEnumerable<StoreModel> GetAllStore()
        {
            int count = 0;

            var list = new List<StoreModel>();
            query = @"select * from Store where _status = 1";
            SqlDataReader reader = null;
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = GetConnection();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                var storeModel = new StoreModel();
                storeModel.Id = Int32.Parse(reader[0].ToString());
                storeModel.Name = reader[1].ToString();
                list.Add(storeModel);
                Console.WriteLine(list[count].Name);
                Console.WriteLine(list[count++].Id);
            }
            //GetConnection().Close();
            
            return list;
        }


        /*public IEnumerable<InventoryModel> GetAll()
        {
            var list = new List<InventoryModel>();
            query = @"select d._id as ID, p._cod as Code, p._name as Name, s._id as IdStore, s._name as Store, d._stock as Stock, d._price as Price from 
                    Detail as d inner join Store s 
                    on d._idStore = s._id
                    right join Product as p 
                    on d._codProduct = p._cod
                    where p._status = 1
                    order by d._id desc";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var inventoryModel = new InventoryModel();
                        inventoryModel.Id = reader[0].ToString() == string.Empty ? 000 : Int32.Parse(reader[0].ToString());
                        inventoryModel.CodProduct = reader[1].ToString() == string.Empty ? "----" : reader[1].ToString();
                        inventoryModel.NameProduct = reader[2].ToString();
                        inventoryModel.IdStore = reader[3].ToString() == string.Empty ? "" : reader[3].ToString();
                        inventoryModel.NameStore = reader[4].ToString() == string.Empty ? "----" : reader[4].ToString();
                        inventoryModel.Stock = reader[5].ToString() == string.Empty ? 000 : Int32.Parse(reader[5].ToString());
                        inventoryModel.Price = reader[6].ToString() == string.Empty ? 000 : float.Parse(reader[6].ToString());
                        list.Add(inventoryModel);
                    }
                }
            }
            return list;
        }*/

        public IEnumerable<InventoryModel> GetByValue(string _search)
        {
            var list = new List<InventoryModel>();
            string name = _search, store = _search;
            query = @"select d._id as ID, p._cod as Code, p._name as Name, s._id as IdStore, s._name as Store, d._stock as Stock, d._price as Price from 
                    Detail as d inner join Store s 
                    on d._idStore = s._id
                    right join Product as p 
                    on d._codProduct = p._cod
                    where p._status = 1 and (p._name like @name+'%' or s._name like @store+'%')
                    order by d._id desc";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@store", SqlDbType.NVarChar).Value = store;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var inventoryModel = new InventoryModel();
                        inventoryModel.Id = reader[0].ToString() == string.Empty ? 000 : Int32.Parse(reader[0].ToString());
                        inventoryModel.CodProduct = reader[1].ToString() == string.Empty ? "----" : reader[1].ToString();
                        inventoryModel.NameProduct = reader[2].ToString();
                        inventoryModel.IdStore = reader[3].ToString() == string.Empty ? "" : reader[3].ToString();
                        inventoryModel.NameStore = reader[4].ToString() == string.Empty ? "----" : reader[4].ToString();
                        inventoryModel.Stock = reader[5].ToString() == string.Empty ? 000 : Int32.Parse(reader[5].ToString());
                        inventoryModel.Price = reader[6].ToString() == string.Empty ? 000 : float.Parse(reader[6].ToString());
                        list.Add(inventoryModel);
                    }
                }
            }
            return list;
        }

    }
}
