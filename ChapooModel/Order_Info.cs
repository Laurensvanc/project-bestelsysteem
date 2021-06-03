using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order_Info
    {
        public TimeSpan Tijd { get; set; }
        public string Naam { get; set; }
        public int WerknemerID { get; set; }
        public Transactie Transactie { get; set; }
        public bool Betaald { get; set; }
        public Order_Info(DateTime StartTijd, string Naam, int WerknemerID, Transactie Transactie, bool Betaald)
        {
            Tijd = DateTime.Now.Subtract(StartTijd);
            this.Naam = Naam;
            this.WerknemerID = WerknemerID;
            this.Transactie = Transactie;
            this.Betaald = Betaald;
        }
    }
}
