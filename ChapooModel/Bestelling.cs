using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Bestelling
    {
        public int TafelID{ get; set; }
        public float TotaalPrijs { get; set; }
        public DateTime Opgenomen { get; set; }
        public string Klacht { get; set; }
        public string Instructies { get; set; }
        public string Status { get; set; }
        public DateTime Voltooid { get; set; }
        public DateTime Aangepast { get; set; }
        public int WerknemerID { get; set; }
        public List<Order_Product> OrderList { get; set; }

        public Bestelling(int TafelID, float TotaalPrijs, string Klacht, string Instructies, string Status, List<Order_Product> OrderList)
        {
            this.TafelID = TafelID;
            this.TotaalPrijs = TotaalPrijs;
            Opgenomen = DateTime.Now;
            this.Klacht = Klacht;
            this.Instructies = Instructies;
            this.Status = Status;
            Aangepast = DateTime.Now;
            this.OrderList = OrderList;
        }
    }
}
