using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ItemsCache
{
    class Database:IRepository
    {
        private SqlConnection sqlconnection;
        
        public List<Products> GetProducts()
        {
            string constr = @"Data Source=TAVDESK091;Initial Catalog=AvailProducts; User Id=sa;Password=test123!@#";
            sqlconnection = new SqlConnection(constr);
            List<Products> productList = new List<Products>();
            string query = "SELECT * FROM AllProducts";
            SqlCommand command = new SqlCommand(query, sqlconnection)
            {
                CommandType = CommandType.Text
            };
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sqlconnection.Open();
            da.Fill(dt);
            sqlconnection.Close();
            foreach (DataRow row in dt.Rows)
            {
                productList.Add(
                    new Products
                    {
                        Id = Convert.ToInt32(row["Id"]),
                        Name = Convert.ToString(row["Name"]),
                        Category=Convert.ToString(row["Category"]),
                        Price = Convert.ToInt32(row["Price"])
                    }
                );

            }
            return productList;
        }

    }
}
