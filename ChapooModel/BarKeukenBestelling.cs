using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class BarKeukenBestelling
    {
        public int OrderID { get; set; }
        public int BestellingID { get; set; }
        public int ProductID { get; set; }
        public int TafelID { get; set; }
        public string ProductNaam { get; set; }
        public bool IsDrinken { get; set; }
        public string Status { get; set; }
        public int Aantal { get; set; }
        public DateTime Opgenomen { get; set; }

        public BarKeukenBestelling(int orderId, int bestellingId, int productId, int tafelId, string productNaam, bool isDrinken, string status, int aantal, DateTime opgenomen)
        {
            OrderID = orderId;
            BestellingID = bestellingId;
            ProductID = productId;
            TafelID = tafelId;
            ProductNaam = productNaam;
            IsDrinken = isDrinken;
            Status = status;
            Aantal = aantal;
            Opgenomen = opgenomen;
        }
    }
}
