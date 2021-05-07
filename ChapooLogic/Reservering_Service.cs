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
                Reservering r = new Reservering(
                404,
                404,
                DateTime.Now.AddSeconds(404),
                DateTime.Now.AddMinutes(404),
                404
                );
                reservering.Add(r);
                return reservering;
                
                throw new Exception("Chapoo kon niet verbinden met de database");
            }
        }
        public void AddReservering(Reservering reservering)
        {
            try
            {
                reserveringDAO.AddReservering(reservering);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
