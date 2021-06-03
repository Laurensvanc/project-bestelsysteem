using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public class TafelDAO : Base
    {
        public List<Tafel> Db_Get_All_Tafels()
        {
            string query = "USE dbchapoo202104 SELECT [Tafel].TafelID, [Tafel].Capaciteit, [Werknemer].Voornaam FROM [Tafel] JOIN [Werknemer] ON [Tafel].WerknemerID = [Werknemer].WerknemerID";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void Db_Update_Tafel_Medewerker(int WerknemerID, int TafelID)
        {
            string query = "USE dbchapoo202104 UPDATE Tafel SET WerknemerID = @WerknemerID WHERE TafelID = @TafelID";
            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@WerknemerID", WerknemerID);
            sqlParameters[1] = new SqlParameter("@TafelID", TafelID);
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel(
                    (string)dr["Voornaam"],
                    (int)dr["Capaciteit"],
                    "Vrij",
                    (int)dr["TafelID"]
                    );

                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
