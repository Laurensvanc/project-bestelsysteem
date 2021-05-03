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
            string query = "SELECT ReserveringID, TafelID, BeginTijd, EindTijd, KlantID FROM Reservering";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Reservering> ReadTables(DataTable dataTable)
        {
            List<Reservering> reserverings = new List<Reservering>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Reservering reservering = new Reservering()
                {
                    ReserveringID = (int)dr["ReserveringID"],
                    TafelID = (int)dr["TafelID"],
                    BeginTijd = (DateTime)dr["BeginTijd"],
                    EindTijd = (DateTime)dr["EindTijd"],
                    KlantID = (int)dr["KlantID"]
                };
                reserverings.Add(reservering);
            }
            return reserverings;
        }
    }
}
