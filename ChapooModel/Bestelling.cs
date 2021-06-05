using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bestelling
    {
        public int BestellingID { get; set; }
        public Tafel Tafel{ get; set; }
        public float TotaalPrijs { get; set; }
        public DateTime Opgenomen { get; set; }
        public string Klacht { get; set; }
        public string Instructies { get; set; }
        public string Status { get; set; }
        public DateTime Voltooid { get; set; }
        public DateTime Aangepast { get; set; }
        public int WerknemerID { get; set; }
        public List<Order_Product> OrderList { get; set; }

        public Bestelling(Tafel Tafel, float TotaalPrijs, string Klacht, string Instructies, string Status, int WerknemerID, List<Order_Product> OrderList)
        {
            this.Tafel = Tafel;
            this.TotaalPrijs = TotaalPrijs;
            Opgenomen = DateTime.Now;
            this.Klacht = Klacht;
            this.Instructies = Instructies;
            this.Status = Status;
            Aangepast = DateTime.Now;
            this.WerknemerID = WerknemerID;
            this.OrderList = OrderList;
        }
        public Bestelling(int BestellingID)
        {
            this.BestellingID = BestellingID;
        }

        public Bestelling(int bestellingId, Tafel tafelId, DateTime opgenomen)
        {
            this.BestellingID = bestellingId;
            this.Tafel = tafelId;
            this.Opgenomen = opgenomen;
        }
    }
}
