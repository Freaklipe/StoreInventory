using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using StoreInventory.Models;
using System.ComponentModel;
using System.Drawing.Text;

namespace StoreInventory.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        private string query;
        public ProductRepository(string _connectionString) 
        {
            this.connectionString = _connectionString;
        }

        public void Add(ProductModel productModel)
        {
            query = "insert into Product values (@code, @name, @description, '1')";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = productModel.Cod;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                cmd.ExecuteNonQuery();
            }
        }

        public void Edit(ProductModel productModel)
        {
            query = @"update Product 
                    set _name=@name, _description=@description
                    where _cod=@code";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = productModel.Cod;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = productModel.Name;
                cmd.Parameters.Add("@description", SqlDbType.NVarChar).Value = productModel.Description;
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete_Restore(char _enable, string cod)
        {
            char status = _enable == '0' ? '0' : '1';
            query = @"update Product 
                    set _status=@status
                    where _cod=@code";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = cod;
                cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<ProductModel> GetAll(char _status)
        {
            char status = _status == '0' ? '0' : '1';// se podia definir directo, pero se agrego una pequena validacion
            var productList = new List<ProductModel>();
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = @"Select * from 
                                    Product where _status = @status
                                    order by _cod desc";
                cmd.Parameters.Add("@status", SqlDbType.NChar).Value = status;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Cod = reader[0].ToString();
                        productModel.Name = reader[1].ToString();
                        productModel.Description = reader[2].ToString();
                        //productModel.Status = 0;
                        productList.Add(productModel);
                    }
                }
            }
            return productList;
        }

        public IEnumerable<ProductModel> GetByValue(string _value, char _status)
        {
            var list = new List<ProductModel>();
            string code = _value, name = _value;
            char status = _status;
            query = @"Select * from Product
                    where _status = @status and (_cod=@code or _name like @name+'%')
                    order by _cod desc";
            using (var conn = new SqlConnection(connectionString))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandText = query;
                cmd.Parameters.Add("@code", SqlDbType.NVarChar).Value = code;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@status", SqlDbType.NChar).Value = status;
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productModel = new ProductModel();
                        productModel.Cod = reader[0].ToString();
                        productModel.Name = reader[1].ToString();
                        productModel.Description = reader[2].ToString();
                        list.Add(productModel);
                    }
                }
            }
            return list;
        }
    }
}
