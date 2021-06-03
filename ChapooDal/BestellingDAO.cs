using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooDal
{
    public class BestellingDAO : Base
    {
        public void Add_Bestelling(Bestelling bestelling)
        {
            // Data gets written to database, primary key is automatically made
            string query = "USE dbchapoo202104 INSERT INTO Bestelling (TafelID, TotaalPrijs, Opgenomen, Klacht, Instructies, Aangepast) VALUES(@TafelID, @TotaalPrijs, @Opgenomen, @Klacht, @Instructies, @Aangepast)";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[6];

            sqlParameters[0] = new SqlParameter("@TafelID", bestelling.TafelID);
            sqlParameters[1] = new SqlParameter("@TotaalPrijs", bestelling.TotaalPrijs);
            sqlParameters[2] = new SqlParameter("@Opgenomen", bestelling.Opgenomen);
            sqlParameters[3] = new SqlParameter("@Klacht", bestelling.Klacht);
            sqlParameters[4] = new SqlParameter("@Instructies", bestelling.Instructies);
            sqlParameters[5] = new SqlParameter("@Aangepast", bestelling.Aangepast);
            ExecuteEditQuery(query, sqlParameters);

            // Get last BestellingID from database
            query = "USE dbchapoo202104 SELECT TOP 1 BestellingID FROM Bestelling ORDER BY BestellingID DESC";
            sqlParameters = new SqlParameter[0];
            int bestellingID = ReadTables(ExecuteSelectQuery(query, sqlParameters), "BestellingID");

            // Data gets written to database
            query = "USE dbchapoo202104 INSERT INTO [Order] (BestellingID) VALUES( @BestellingID)";
            sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", bestellingID);
            ExecuteEditQuery(query, sqlParameters);

            // Get last OrderID from database
            query = "USE dbchapoo202104 SELECT TOP 1 OrderID FROM [Order] ORDER BY OrderID DESC";
            sqlParameters = new SqlParameter[0];
            int orderID = ReadTables(ExecuteSelectQuery(query, sqlParameters), "OrderID");

            foreach (Order_Product productItem in bestelling.OrderList)
            {
                // Data gets written to database, primary key is automatically made
                query = "USE dbchapoo202104 INSERT INTO Order_Product (OrderID, ProductID, Aantal, Status) VALUES(@OrderID, @ProductID, @Aantal, @Status)";
                sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@OrderID", orderID);
                sqlParameters[1] = new SqlParameter("@ProductID", productItem.ProductID);
                sqlParameters[2] = new SqlParameter("@Aantal", productItem.Aantal);
                sqlParameters[3] = new SqlParameter("@Status", bestelling.Status);
                ExecuteEditQuery(query, sqlParameters);
                // Remove from stock
                query = "USE dbchapoo202104 UPDATE Product SET Aantal = Aantal - @Aantal WHERE ProductID = @ProductID";
                sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@ProductID", productItem.ProductID);
                sqlParameters[1] = new SqlParameter("@Aantal", productItem.Aantal);
                ExecuteEditQuery(query, sqlParameters);
            }
        }
        private int ReadTables(DataTable dataTable, string idType)
        {
            int id = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                id = (int)dr[idType];
            }
            return id;
        }
    }
}
