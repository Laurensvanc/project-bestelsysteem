using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDAL;
using ChapooModel;

namespace ChapooDal
{
    public class Order_ProductDAO : Base
    {
        public List<Order_Product> Db_Get_All_Orders_Product()
        {
            string query = @"SELECT [ProductID], [Aantal]
                            FROM [Order_Product]";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable queryResult = ExecuteSelectQuery(query, sqlParameters);
            List<Order_Product> order_products = ReadTables(queryResult);

            return order_products;
        }

        private List<Order_Product> ReadTables(DataTable dataTable)
        {
            List<Order_Product> order_products = new List<Order_Product>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Order_Product order_product = new Order_Product(
                    (int)dr["ProductID"],
                    (int)dr["Aantal"]
                    );

                order_products.Add(order_product);
            }
            return order_products;
        }
    }
}
