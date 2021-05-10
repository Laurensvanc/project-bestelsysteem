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
    public class AccountDAO : Base
    {
        public void RegisterAccount(Account account)
        {
            // Data gets written to database, primary key is automatically made
            string query1 = "USE dbchapoo202104 INSERT INTO Werknemer (Geboortedatum, Voornaam, Achternaam, Mobiel, Email) VALUES(@Geboortedatum, @Voornaam, @Achternaam, @Mobiel, @Email)";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters1 = new SqlParameter[5];

            sqlParameters1[0] = new SqlParameter("@Geboortedatum", account.GeboorteDatum.ToString("yyyy-MM-dd"));
            sqlParameters1[1] = new SqlParameter("@Voornaam", account.Voornaam);
            sqlParameters1[2] = new SqlParameter("@Achternaam", account.Achternaam);
            sqlParameters1[3] = new SqlParameter("@Mobiel", account.Telefoonnummer);
            sqlParameters1[4] = new SqlParameter("@Email", account.Email);
            ExecuteEditQuery(query1, sqlParameters1);
            
            // Get werknemerID from database
            string query2 = "USE dbchapoo202104 SELECT TOP 1 WerknemerID FROM [Werknemer] ORDER BY WerknemerID DESC";
            SqlParameter[] sqlParameters2 = new SqlParameter[0];
            int werknemerID = ReadTables(ExecuteSelectQuery(query2, sqlParameters2));

            // Data gets written to database, primary key is automatically made
            string query3 = "USE dbchapoo202104 INSERT INTO Account (WerknemerID, Inlognaam, Wachtwoord, Manager, Chef, Bediening, Keuken, Sommelier, Maitre, Bar) VALUES(@WerknemerID, @Inlognaam, @Wachtwoord, @Manager, @Chef, @Bediening, @Keuken, @Sommelier, @Maitre, @Bar)";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters3 = new SqlParameter[10];

            sqlParameters3[0] = new SqlParameter("@WerknemerID", werknemerID);
            sqlParameters3[1] = new SqlParameter("@Inlognaam", account.Inlognaam);
            sqlParameters3[2] = new SqlParameter("@Wachtwoord", account.Wachtwoord);
            sqlParameters3[3] = new SqlParameter("@Manager", account.Manager);
            sqlParameters3[4] = new SqlParameter("@Chef", account.Chef);
            sqlParameters3[5] = new SqlParameter("@Bediening", account.Bediening);
            sqlParameters3[6] = new SqlParameter("@Keuken", account.Keuken);
            sqlParameters3[7] = new SqlParameter("@Sommelier", account.Sommelier);
            sqlParameters3[8] = new SqlParameter("@Maitre", account.Maitre);
            sqlParameters3[9] = new SqlParameter("@Bar", account.Bar);
            ExecuteEditQuery(query3, sqlParameters3);
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
    }
}
