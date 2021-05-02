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
    public class TafelDAO : Base
    {
        public List<Tafel> Db_Get_All_Tafels()
        {
            string query = "SELECT TafelID, Capaciteit, Status, WerknemerID FROM Tafel";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Tafel> ReadTables(DataTable dataTable)
        {
            List<Tafel> tafels = new List<Tafel>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Tafel tafel = new Tafel()
                {
                    WerknemerId = (int)dr["WerknemerID"],
                    Capaciteit = (int)dr["Capaciteit"],
                    Status = (string)dr["Status"],
                    TafelNummer = (int)dr["TafelID"]
                };
                tafels.Add(tafel);
            }
            return tafels;
        }
    }
}
