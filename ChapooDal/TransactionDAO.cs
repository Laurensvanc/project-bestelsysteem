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
    public class TransactionDAO : Base
    {
        public List<int> DB_Get_Tables()
        {
            // Get TafelID with no transactions made
            string query = "USE dbchapoo202104 SELECT DISTINCT TafelID FROM Bestelling WHERE BestellingID NOT IN (SELECT BestellingID FROM Transactie_Bestelling) ORDER BY TafelID;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            List<int> tableList = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            return tableList;
        }
        public Order_Info DB_Get_Order_Info(int TafelID)
        {
            string query = "USE dbchapoo202104 SELECT TOP 1[Bestelling].Opgenomen, [Werknemer].Voornaam + ' ' + [Werknemer].Achternaam AS Naam, [Werknemer].WerknemerID, [Transactie].TransactieID, [Transactie].Betaald FROM Bestelling  INNER JOIN Werknemer ON[Werknemer].WerknemerID = [Bestelling].WerknemerID CROSS JOIN Transactie ORDER BY TransactieID DESC";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            Order_Info info = ReadTablesInfo(ExecuteSelectQuery(query, sqlParameters));
            return info;
        }
        public void DB_Add_Transaction()
        {
            // Data gets written to database, primary key is automatically made
            string query = "USE dbchapoo202104 INSERT INTO Transactie(Betaald, Bongeprint, Betaalwijze) VALUES(0, 0, 'pin')";
            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<Order> DB_Get_Orders(int TafelID)
        {
            string query = "USE dbchapoo202104 SELECT [Bestelling].BestellingID, [Product].ProductNaam, [Product].Prijs, [Order_Product].Aantal, [Product].IsAlcohol FROM Bestelling AS [Bestelling] INNER JOIN [Order] ON [Order].BestellingID = [Bestelling].BestellingID INNER JOIN[Order_Product] ON [Order_Product].OrderID = [Order].OrderID INNER JOIN[Product] ON[Product].ProductID = [Order_Product].ProductID WHERE[Bestelling].TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@TafelID", TafelID);
            List<Order> orderList = ReadTablesOrder(ExecuteSelectQuery(query, sqlParameters));
            return orderList;
        }
        public bool DB_Update_Transaction(Transactie transactie)
        {
            string query = "USE dbchapoo202104 UPDATE Transactie SET Betaald = 1, BetaalTijd = @BetaalTijd, BonGeprint = @BonGeprint, WerknemerID = @WerknemerID, Opmerking = @Opmerking, BedragBetaald = @BedragBetaald, Fooi = @Fooi, Betaalwijze = @Betaalwijze WHERE TransactieID = @TransactieID;";
            SqlParameter[] sqlParameters = new SqlParameter[8];
            sqlParameters[0] = new SqlParameter("@BetaalTijd", transactie.BetaalTijd);
            sqlParameters[1] = new SqlParameter("@BonGeprint", transactie.BonGeprint);
            sqlParameters[2] = new SqlParameter("@WerknemerID", transactie.WerknemerID);
            sqlParameters[3] = new SqlParameter("@Opmerking", transactie.Opmerking);
            sqlParameters[4] = new SqlParameter("@BedragBetaald", transactie.BedragBetaald);
            sqlParameters[5] = new SqlParameter("@Fooi", transactie.Fooi);
            sqlParameters[6] = new SqlParameter("@Betaalwijze", transactie.Betaalwijze);
            sqlParameters[7] = new SqlParameter("@TransactieID", transactie.TransactieID);
            ExecuteEditQuery(query, sqlParameters);

            foreach (int BestellingID in transactie.BestellingIDs)
            {
                query = "USE dbchapoo202104 INSERT INTO Transactie_Bestelling(TransactieID, BestellingID) VALUES(@TransactieID, @BestellingID)";
                sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@TransactieID", transactie.TransactieID);
                sqlParameters[1] = new SqlParameter("@BestellingID", BestellingID);
                ExecuteEditQuery(query, sqlParameters);
            }
            return true;
        }

        private List<int> ReadTables(DataTable dataTable)
        {
            List<int> tableList = new List<int>();
            foreach (DataRow dr in dataTable.Rows)
            {
                tableList.Add((int)dr["TafelID"]); 
            }
            return tableList;
        }
        private Order_Info ReadTablesInfo(DataTable dataTable)
        {
            Order_Info info = new Order_Info(DateTime.Now, "Empty", 0, 0, false);
            foreach (DataRow dr in dataTable.Rows)
            {
                info = new Order_Info(
                    (DateTime)dr["Opgenomen"],
                    (string)dr["Naam"],
                    (int)dr["WerknemerID"],
                    (int)dr["TransactieID"],
                    (bool)dr["Betaald"]);
            }
            return info;
        }
        private List<Order> ReadTablesOrder(DataTable dataTable)
        {
            List<Order> orderList = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order(
                    (int)dr["BestellingID"],
                    (string)dr["ProductNaam"],
                    (double)dr["Prijs"],
                    (int)dr["Aantal"],
                    (bool)dr["IsAlcohol"]);
                orderList.Add(order);
            }
            return orderList;
        }
    }
}
