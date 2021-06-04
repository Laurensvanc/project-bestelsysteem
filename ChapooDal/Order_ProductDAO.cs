﻿using System;
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

        public void Update_Order_Status(int orderId, int productId, string status, int aantal)
        {
            if (aantal > 1) 
            {
                string insertQuery = "INSERT INTO Order_Product (OrderID, ProductID, Aantal, [Status]) VALUES (@OrderID, @ProductID, @Aantal, @Status)";
                SqlParameter[] insertSqlParameter = new SqlParameter[4];

                insertSqlParameter[0] = new SqlParameter("@OrderID", orderId);
                insertSqlParameter[1] = new SqlParameter("@ProductID", productId);
                insertSqlParameter[2] = new SqlParameter("@Aantal", 1);
                insertSqlParameter[3] = new SqlParameter("@Status", status);
                ExecuteEditQuery(insertQuery, insertSqlParameter);

                status = "Nieuw";
                aantal--;
            }

            string updateQuery = @"UPDATE Order_Product
                                SET [Status] = @Status, Aantal = @Aantal
                                FROM Order_Product
	                            WHERE OrderID = @OrderID
	                            AND ProductID = @ProductID";
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@Status", status);
            sqlParameters[1] = new SqlParameter("@Aantal", aantal);
            sqlParameters[2] = new SqlParameter("@OrderID", orderId);
            sqlParameters[3] = new SqlParameter("@ProductID", productId);


            ExecuteEditQuery(updateQuery, sqlParameters);
        }

        public List<Order_Product> Db_Get_All_Order_Products()
        {
            string query = @"SELECT op.OrderID, o.BestellingID, op.ProductID, b.TafelID, p.ProductNaam, p.IsDrinken, op.[Status], op.Aantal, b.Opgenomen
                                FROM Order_Product AS op
                                JOIN[Order] AS o
                                ON op.OrderID = o.OrderID
                                JOIN[Bestelling] AS b
                                ON o.BestellingID = b.BestellingID
                                JOIN Product AS p
                                ON op.ProductID = p.ProductID";
            SqlParameter[] sqlParameters = new SqlParameter[0];

            DataTable queryResult = ExecuteSelectQuery(query, sqlParameters);
            List<Order_Product> orderProduct = ReadOrderProductProductBestelling(queryResult);

            return orderProduct;
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

        private List<Order_Product> ReadOrderProductProductBestelling(DataTable dataTable)
        {
            List<Order_Product> orderProducts = new List<Order_Product>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Order_Product orderProduct = new Order_Product(
                    (int)dr["OrderID"],
                    (String)dr["Status"],
                    (int)dr["Aantal"],
                    new Product(
                        (int)dr["ProductID"],
                        (String)dr["ProductNaam"],
                        (bool)dr["IsDrinken"]),
                    new Bestelling(
                        (int)dr["BestellingID"], 
                        new Tafel((int)dr["TafelID"]),
                        (DateTime)dr["Opgenomen"]));

                orderProducts.Add(orderProduct);
            }
            return orderProducts;
        }
    }
}
