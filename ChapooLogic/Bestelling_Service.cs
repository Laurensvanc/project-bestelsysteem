using ChapooDal;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Bestelling_Service
    {
        BestellingDAO bestellingDAO = new BestellingDAO();
        public bool AddBestelling(Bestelling bestelling)
        {
            try
            {
                bestellingDAO.Add_Bestelling(bestelling);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
