using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Lab5.entity;
using Lab5.services;

namespace Lab5.dao
{
    public class ProductDaoImpl : ProductDao
    {
        public void createProduct(Product product)
        {


            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();
            string query = "INSERT INTO Product values(@proName,@proDesc,@price)";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter proName = new SqlParameter("@proName", product.proName);
            SqlParameter proDesc = new SqlParameter("@proDesc", product.proDesc);
            SqlParameter price = new SqlParameter("@price", product.price);
            command.Parameters.Add(proName);
            command.Parameters.Add(proDesc);
            command.Parameters.Add(price);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Them ban ghi {0} thanh cong", dataCount);
            conn.Close();

        }

        public void deleteProduct(string name)
        {

            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();

            string queery = "DELETE FROM Product WHERE proName=@proName";
            SqlCommand command = new SqlCommand(queery, conn);
            SqlParameter proName = new SqlParameter("@proName", name);
            command.Parameters.Add(proName);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Delete " + dataCount + "success");
        }

        public ArrayList getAll()
        {
            SqlConnectiondb connectionString = new SqlConnectiondb();
            SqlConnection connection = connectionString.GetSqlConnection();

            ArrayList list = new ArrayList();
            string query = "select * from product";
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                list.Add(reader[1]);
            }
            connection.Close();
            return list;


        }

        public void searchProduct(string name)
        {
            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();
            string query = "SELECT * FROM Product WHERE proName=@proName";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter proName = new SqlParameter("@proName", name);
            command.Parameters.Add(proName);
            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("product name:" + reader[1]);

            }
            conn.Close();
        }

        public void updateProduct(Product product)
        {
            SqlConnectiondb sqlConnectiondb = new SqlConnectiondb();
            SqlConnection conn = sqlConnectiondb.GetSqlConnection();
            string query = "Update Product SET proDesc=@proDesc,price=@price WHERE proName=@proName";
            SqlCommand command = new SqlCommand(query, conn);
            SqlParameter proName = new SqlParameter("@proName", product.proName);
            SqlParameter proDesc = new SqlParameter("@proDesc", product.proDesc);
            SqlParameter price = new SqlParameter("@price", product.price);
            command.Parameters.Add(proName);
            command.Parameters.Add(proDesc);
            command.Parameters.Add(price);
            conn.Open();
            int dataCount = command.ExecuteNonQuery();
            Console.WriteLine("Update ban ghi {0} thanh cong", dataCount);
            conn.Close();
        }
    }
}
