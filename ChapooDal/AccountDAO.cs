using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
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

        public void ResetPassword(string account, string encryptedwachtwoord)
        {
            string query = "USE dbchapoo202104 UPDATE [Account] SET Wachtwoord = @Wachtwoord WHERE Inlognaam = @inlognaam";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@inlognaam", account);
            sqlParameters[1] = new SqlParameter("@Wachtwoord", encryptedwachtwoord);
            ExecuteEditQuery(query, sqlParameters);

        }

        public void UpdateLastLoginAccount(string account)
        {
           
                string query = "USE dbchapoo202104 UPDATE [Account] SET LaatsteLogin = @time WHERE Inlognaam = @inlognaam";
                SqlParameter[] sqlParameters = new SqlParameter[2];
                sqlParameters[0] = new SqlParameter("@inlognaam", account);
                sqlParameters[1] = new SqlParameter("@time", DateTime.Now);
                ExecuteEditQuery(query, sqlParameters);
                
          
        }

        public Account GetAccount(string account)
        {
            string query = "USE dbchapoo202104 SELECT WerknemerID,Inlognaam,Wachtwoord,Manager,Chef,Bediening,Keuken,Sommelier,Maitre,Bar FROM [Account] WHERE Inlognaam = @inlognaam";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@inlognaam", account);
            return ReadAccount(ExecuteSelectQuery(query, sqlParameters));
        }
        CultureInfo provider = CultureInfo.InvariantCulture;
        private Account ReadAccount(DataTable dataTable)
        {
            string Voornaam = string.Empty;
            string Achternaam = string.Empty;
            string Inlognaam = string.Empty;
            DateTime GeboorteDatum = DateTime.MinValue;
            int Telefoonnummer = 0;
            string Email = string.Empty;
            string Wachtwoord = string.Empty;
            int Manager = 0;
            int Chef = 0;
            int Bediening = 0;
            int Keuken = 0;
            int Sommelier = 0;
            int Maitre = 0;
            int Bar = 0;

            int WerknemerID = 0;
        

            foreach (DataRow dr in dataTable.Rows)
            {
                Wachtwoord = dr["Wachtwoord"].ToString();
                Inlognaam = dr["Inlognaam"].ToString();
                WerknemerID = Int32.Parse(dr["WerknemerID"].ToString());
                Manager = Convert.ToInt32(Convert.ToBoolean(dr["Manager"].ToString()));

                Chef = Convert.ToInt32(Convert.ToBoolean(dr["Chef"].ToString()));
                Bediening = Convert.ToInt32(Convert.ToBoolean(dr["Bediening"].ToString()));
                Keuken = Convert.ToInt32(Convert.ToBoolean(dr["Keuken"].ToString()));
                Sommelier = Convert.ToInt32(Convert.ToBoolean(dr["Sommelier"].ToString()));
                Maitre = Convert.ToInt32(Convert.ToBoolean(dr["Maitre"].ToString()));
                Bar = Convert.ToInt32(Convert.ToBoolean(dr["Bar"].ToString()));
            }

            string query = "USE dbchapoo202104 SELECT WerknemerID,Voornaam,Achternaam,Mobiel,Email,Geboortedatum FROM [Werknemer] WHERE WerknemerID = @werknemerid";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@werknemerid", WerknemerID);
            DataTable data = ExecuteSelectQuery(query, sqlParameters);
            foreach (DataRow dr in data.Rows)
            {
                Voornaam = dr["Voornaam"].ToString();
                Achternaam = dr["Achternaam"].ToString();
                GeboorteDatum = DateTime.Parse(dr["Geboortedatum"].ToString());
                Telefoonnummer = Int32.Parse(dr["Mobiel"].ToString());
                Email = dr["Email"].ToString();
            }

            
                return new Account(WerknemerID, Voornaam, Achternaam, Inlognaam, GeboorteDatum, Telefoonnummer, Email, Wachtwoord, Manager, Chef, Bediening, Keuken, Sommelier, Maitre, Bar);
            
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
