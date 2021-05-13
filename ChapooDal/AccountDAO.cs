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
            string query = "USE dbchapoo202104 INSERT INTO Werknemer (Geboortedatum, Voornaam, Achternaam, Mobiel, Email) VALUES(@Geboortedatum, @Voornaam, @Achternaam, @Mobiel, @Email)";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@Geboortedatum", account.GeboorteDatum.ToString("yyyy-MM-dd"));
            sqlParameters[1] = new SqlParameter("@Voornaam", account.Voornaam);
            sqlParameters[2] = new SqlParameter("@Achternaam", account.Achternaam);
            sqlParameters[3] = new SqlParameter("@Mobiel", account.Telefoonnummer);
            sqlParameters[4] = new SqlParameter("@Email", account.Email);
            ExecuteEditQuery(query, sqlParameters);
            
            // Get werknemerID from database
            query = "USE dbchapoo202104 SELECT TOP 1 WerknemerID FROM [Werknemer] ORDER BY WerknemerID DESC";
            sqlParameters = new SqlParameter[0];
            int werknemerID = ReadTables(ExecuteSelectQuery(query, sqlParameters));

            // Data gets written to database, primary key is automatically made
            query = "USE dbchapoo202104 INSERT INTO Account (WerknemerID, Inlognaam, Wachtwoord, Manager, Chef, Bediening, Keuken, Sommelier, Maitre, Bar) VALUES(@WerknemerID, @Inlognaam, @Wachtwoord, @Manager, @Chef, @Bediening, @Keuken, @Sommelier, @Maitre, @Bar)";

            // Setting the parameters from the parameter order
            sqlParameters = new SqlParameter[10];

            sqlParameters[0] = new SqlParameter("@WerknemerID", werknemerID);
            sqlParameters[1] = new SqlParameter("@Inlognaam", account.Inlognaam);
            sqlParameters[2] = new SqlParameter("@Wachtwoord", account.Wachtwoord);
            sqlParameters[3] = new SqlParameter("@Manager", account.Manager);
            sqlParameters[4] = new SqlParameter("@Chef", account.Chef);
            sqlParameters[5] = new SqlParameter("@Bediening", account.Bediening);
            sqlParameters[6] = new SqlParameter("@Keuken", account.Keuken);
            sqlParameters[7] = new SqlParameter("@Sommelier", account.Sommelier);
            sqlParameters[8] = new SqlParameter("@Maitre", account.Maitre);
            sqlParameters[9] = new SqlParameter("@Bar", account.Bar);
            ExecuteEditQuery(query, sqlParameters);
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
