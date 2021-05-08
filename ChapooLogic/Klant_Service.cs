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
    public class Klant_Service
    {
        KlantDAO klantDAO = new KlantDAO();
        public List<Klant> GetKlants()
        {
            try
            {
                List<Klant> klanten = klantDAO.Db_Get_All_Klanten();
                return klanten;
            }
            catch (Exception e)
            {
                List<Klant> klants = new List<Klant>();
                Klant k = new Klant("ERROR", "ERROR", DateTime.Now.ToString(), "07299999", 404);
                klants.Add(k);
                Console.WriteLine(e.Message);
                return klants;
            }
        }
        public void AddKlant(Klant klant)
        {
            try
            {
                klantDAO.AddKlant(klant);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
