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
    public class Tafel_Service
    {
        private TafelDAO tafelDAO = new TafelDAO();

        public List<Tafel> GetTafels()
        {
            try
            {
                List<Tafel> tafel = tafelDAO.Db_Get_All_Tafels();
                return tafel;
            }
            catch(Exception ex)
            {
                List<Tafel> tafel = new List<Tafel>();
                Tafel t = new Tafel(
                "Niemand",
                404,
                "Error",
                404
                );
                tafel.Add(t);
                return tafel;
                
                throw new Exception("Chapoo kon niet verbinden met de database");
            }
        }
    }
}
