using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ChapooLogic
{
    public class Reservering_Service
    {

        ReserveringDAO reserveringDAO = new ReserveringDAO();

        public List<Reservering> GetReserverings()
        {
            try
            {
                List<Reservering> reservering = reserveringDAO.Db_Get_All_Tafels();
                return reservering;
            }
            catch(Exception ex)
            {
                List<Reservering> reservering = new List<Reservering>();
                Reservering r = new Reservering();
                r.KlantID = 404;
                r.ReserveringID = 404;
                r.TafelID = 404;
                r.BeginTijd = DateTime.Now.AddSeconds(404);
                r.EindTijd = DateTime.Now.AddMinutes(404);
                reservering.Add(r);
                return reservering;
                
                throw new Exception("Chapoo kon niet verbinden met de database");
            }
        }
    }
}
