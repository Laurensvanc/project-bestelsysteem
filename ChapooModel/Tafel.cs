using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooModel
{
    public class Tafel
    {
        public int TafelNummer { get; set; }
        public int Capaciteit { get; set; }
        public string Status { get; set; }
        public string WerknemerId { get; set; }

        public Tafel(string WerknemerId, int Capaciteit, string Status, int TafelNummer)
        {
            this.TafelNummer = TafelNummer;
            this.Capaciteit = Capaciteit;
            this.Status = Status;
            this.WerknemerId = WerknemerId;
        }
    }
}
