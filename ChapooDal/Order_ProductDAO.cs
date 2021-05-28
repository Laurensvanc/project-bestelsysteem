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
            List<Order_Product> orderProducts = ReadTables(queryResult);

            return orderProducts;
        }

        public List<BarKeukenBestelling> Db_Get_All_BarKeuken_Bestellingen()
        {
            string query = @"SELECT op.OrderID, o.BestellingID, op.ProductID, b.TafelID, p.ProductNaam, b.[Status], op.Aantal
                                FROM Order_Product AS op
                                JOIN[Order] AS o
                                ON op.OrderID = o.OrderID
                                JOIN[Bestelling] AS b
                                ON o.BestellingID = b.BestellingID
                                JOIN Product AS p
                                ON op.ProductID = p.ProductID";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable queryResult = ExecuteSelectQuery(query, sqlParameters);
            List<BarKeukenBestelling> barKeukenBestellingen = ReadBarKeukenBestellingTables(queryResult);

            return barKeukenBestellingen;
        }

        private List<Order_Product> ReadTables(DataTable dataTable)
        {
            List<Order_Product> orderProducts = new List<Order_Product>();

            foreach (DataRow dr in dataTable.Rows)
            {

                Order_Product order_product = new Order_Product(
                    (int)dr["ProductID"],
                    (int)dr["Aantal"]
                    );

                orderProducts.Add(order_product);
            }
            return orderProducts;
        }

        private List<BarKeukenBestelling> ReadBarKeukenBestellingTables(DataTable dataTable)
        {
            List<BarKeukenBestelling> barKeukenBestellingen = new List<BarKeukenBestelling>();

            foreach (DataRow dr in dataTable.Rows)
            {

                BarKeukenBestelling barKeukenBestelling = new BarKeukenBestelling(
                    (int)dr["OrderID"],
                    (int)dr["BestellingID"],
                    (int)dr["ProductID"],
                    (int)dr["TafelID"],
                    (String)dr["ProductNaam"],
                    (String)dr["Status"],
                    (int)dr["Aantal"]
                    );

                barKeukenBestellingen.Add(barKeukenBestelling);
            }
            return barKeukenBestellingen;
        }
    }
}
