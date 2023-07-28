using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StoreInventory.Models;

namespace StoreInventory.Repositories
{
    public class StoreRepository : BaseRepository, IStoreRepository
    {
        // Constructor
        public StoreRepository(string _connectionString) 
        {
            this.connectionString = _connectionString;
        }

        // Methods
        public void Add(StoreModel storeModel)
        {
            int v = 1;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "insert into Store values (@name, @address, @description, @status)";
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = storeModel.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = storeModel.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = storeModel.Address;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = storeModel.Description;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = v;
                cmd.ExecuteNonQuery();
            }
        }

        // Real Delete
        /*public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = "delete from Store where _id=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }*/

        // Disable Status = Delete View System
        public void Delete(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"update Store 
                                    set _status=0
                                    where _id=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        public void Restore(int id)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"update Store 
                                    set _status=1
                                    where _id=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.ExecuteNonQuery();
            }
        }

        public void Edit(StoreModel storeModel)
        {
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"update Store 
                                    set _name=@name, _address=@address, _description=@description 
                                    where _id=@id";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = storeModel.Id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = storeModel.Name;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = storeModel.Address;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = storeModel.Description;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<StoreModel> GetAll(byte value)
        {
            var storeList = new List<StoreModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"Select * from 
                                    Store where _status = @status
                                    order by _id desc";
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = value;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var storeModel = new StoreModel();
                        storeModel.Id = (int)reader[0];
                        storeModel.Name = reader[1].ToString();
                        storeModel.Address = reader[2].ToString();
                        storeModel.Description = reader[3].ToString();
                        storeList.Add(storeModel);
                    }
                }
            }
            return storeList;
        }

        public IEnumerable<StoreModel> GetByValue(string value, byte arg)
        {
            var storeList = new List<StoreModel>();
            int id = int.TryParse(value, out _) ? Convert.ToInt32(value) : -1;//uso -1 por tema de _id
            //string name = value;
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"Select * from Store
                                    where _status = @status and (_id=@id or _name like @name+'%')
                                    order by _id desc";
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = value;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = arg;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var storeModel = new StoreModel();
                        storeModel.Id = (int)reader[0];
                        storeModel.Name = reader[1].ToString();
                        storeModel.Address = reader[2].ToString();
                        storeModel.Description = reader[3].ToString();
                        storeList.Add(storeModel);
                    }
                }
            }
            return storeList;
        }
    }
}
