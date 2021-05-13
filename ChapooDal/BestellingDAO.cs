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
            // Get werknemerID from database
            string query = "USE dbchapoo202104 SELECT WerknemerID FROM Tafel WHERE TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TafelID", bestelling.TafelID);
            bestelling.WerknemerID = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            // Data gets written to database, primary key is automatically made
             query = "USE dbchapoo202104 INSERT INTO Bestelling (TafelID, TotaalPrijs, Opgenomen, Klacht, Instructies, [Status], Aangepast, WerknemerID) VALUES(@TafelID, @TotaalPrijs, @Opgenomen, @Klacht, @Instructies, @Status, @Aangepast, @WerknemerID)";

            // Setting the parameters from the parameter order
            sqlParameters = new SqlParameter[8];

            sqlParameters[0] = new SqlParameter("@TafelID", bestelling.TafelID);
            sqlParameters[1] = new SqlParameter("@TotaalPrijs", bestelling.TotaalPrijs);
            sqlParameters[2] = new SqlParameter("@Opgenomen", bestelling.Opgenomen);
            sqlParameters[3] = new SqlParameter("@Klacht", bestelling.Klacht);
            sqlParameters[4] = new SqlParameter("@Instructies", bestelling.Instructies);
            sqlParameters[5] = new SqlParameter("@Status", bestelling.Status);
            sqlParameters[6] = new SqlParameter("@Aangepast", bestelling.Aangepast);
            sqlParameters[7] = new SqlParameter("@WerknemerID", bestelling.WerknemerID);
            ExecuteEditQuery(query, sqlParameters);

            // Get last BestellingID from database
            query = "USE dbchapoo202104 SELECT TOP 1 BestellingID FROM Bestelling ORDER BY BestellingID DESC";
            sqlParameters = new SqlParameter[0];
            int bestellingID = ReadTablesBesID(ExecuteSelectQuery(query, sqlParameters));

            // Data gets written to database
            query = "USE dbchapoo202104 INSERT INTO [Order] (BestellingID) VALUES( @BestellingID)";
            sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@BestellingID", bestellingID);
            ExecuteEditQuery(query, sqlParameters);

            // Get last OrderID from database
            query = "USE dbchapoo202104 SELECT TOP 1 OrderID FROM [Order] ORDER BY OrderID DESC";
            sqlParameters = new SqlParameter[0];
            int orderID = ReadTablesOrdID(ExecuteSelectQuery(query, sqlParameters));

            foreach (Order_Product productItem in bestelling.OrderList)
            {
                // Data gets written to database, primary key is automatically made
                query = "USE dbchapoo202104 INSERT INTO Order_Product (OrderID, ProductID, Aantal) VALUES(@OrderID, @ProductID, @Aantal)";
                sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@OrderID", orderID);
                sqlParameters[1] = new SqlParameter("@ProductID", productItem.ProductID);
                sqlParameters[2] = new SqlParameter("@Aantal", productItem.Aantal);
                ExecuteEditQuery(query, sqlParameters);
            }
            
        }
        private int ReadTables(DataTable dataTable)
        {
            int id = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                id = (int)dr["WerknemerID"];
            }
            return id;
        }
        private int ReadTablesBesID(DataTable dataTable)
        {
            int id = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                id = (int)dr["BestellingID"];
            }
            return id;
        }
        private int ReadTablesOrdID(DataTable dataTable)
        {
            int id = 0;
            foreach (DataRow dr in dataTable.Rows)
            {
                id = (int)dr["OrderID"];
            }
            return id;
        }
    }
}
