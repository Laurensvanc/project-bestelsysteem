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
    public class ReserveringDAO : Base
    {
        public List<Reservering> Db_Get_All_Tafels()
        {
            string query = "SELECT [Klant].Voornaam, [Reservering].ReserveringID, [Reservering].TafelID, [Reservering].BeginTijd, [Reservering].EindTijd, [Reservering].KlantID, [Reservering].AantalPersonen FROM [Reservering] JOIN [Klant] ON [Reservering].KlantID = [Klant].KlantID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Reservering> ReadTables(DataTable dataTable)
        {
            List<Reservering> reserverings = new List<Reservering>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel((int)dr["TafelID"]);
                Klant klant = new Klant((int)dr["KlantID"]);
                Reservering reservering = new Reservering(

                    (String)dr["Voornaam"],
                    (int)dr["ReserveringID"],
                    tafel,
                    (DateTime)dr["BeginTijd"],
                    (DateTime)dr["EindTijd"],
                    klant,
                    (int)dr["AantalPersonen"]
                    );
                
                reserverings.Add(reservering);
            }
            return reserverings;
        }
        public void AddReservering(Reservering reservering)
        {
            // Data gets written to database, primary key is automatically made
            string query = "USE dbchapoo202104 INSERT INTO Reservering (TafelID, BeginTijd, EindTijd, KlantID, AantalPersonen) VALUES(@TafelID, @Begin, @Eind, @KlantID, @Aantal); ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[5];

            sqlParameters[0] = new SqlParameter("@TafelID", reservering.Tafel.TafelNummer);
            sqlParameters[1] = new SqlParameter("@Begin", reservering.BeginTijd);
            sqlParameters[2] = new SqlParameter("@Eind", reservering.EindTijd);
            sqlParameters[3] = new SqlParameter("@KlantID", reservering.Klant.KlantID);
            sqlParameters[4] = new SqlParameter("@Aantal", reservering.AantalPersonen);
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteReservering(Reservering reservering)
        {
            // Data gets changed in database
            string query = "USE dbchapoo202104 DELETE FROM Reservering WHERE ReserveringID = @ReserveringID; ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@ReserveringID", reservering.ReserveringID);

            ExecuteEditQuery(query, sqlParameters);
        }
    }
}
