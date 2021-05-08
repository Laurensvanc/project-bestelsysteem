using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;

namespace ChapooDAL
{
    public class KlantDAO : Base
    {
        public List<Klant> Db_Get_All_Klanten()
    {
        string query = "USE dbchapoo202104 SELECT Voornaam, Achternaam, Geboortedatum, LaatsteBezoek, Mobiel, HuisTelefoon, Email, KlantID FROM [Klant]";
        SqlParameter[] sqlParameters = new SqlParameter[0];
        return ReadTables(ExecuteSelectQuery(query, sqlParameters));
    }

    private List<Klant> ReadTables(DataTable dataTable)
    {
        List<Klant> klants = new List<Klant>();

        foreach (DataRow dr in dataTable.Rows)
        {
            Klant klant = new Klant(

                (string)dr["Voornaam"],
                (string)dr["Achternaam"],
                (string)dr["Geboortedatum"],
                (string)dr["Mobiel"],
                (int)dr["KlantID"]
                );

          klants.Add(klant);
        }
        return klants;
    }
    public void AddKlant(Klant klant)
        {
            // Data gets written to database, primary key is automatically made
            string query = "USE dbchapoo202104 INSERT INTO Klant (Voornaam, Achternaam, Geboortedatum, Mobiel) VALUES(@Voornaam, @Achternaam, @Geboortedatum, @Mobiel)";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[4];

            sqlParameters[0] = new SqlParameter("@Voornaam", klant.Voornaam);
            sqlParameters[1] = new SqlParameter("@Achternaam", klant.Achternaam);
            sqlParameters[2] = new SqlParameter("@Geboortedatum", klant.GeboorteDatum);
            sqlParameters[3] = new SqlParameter("@Mobiel", klant.Mobiel);
            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
