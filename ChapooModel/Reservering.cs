using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooModel
{
    public class Reservering
    {
        public int ReserveringID { get; set; }
        public int TafelID { get; set; }
        public DateTime BeginTijd { get; set; }
        public DateTime EindTijd { get; set; }
        public int KlantID { get; set; }

        public string KlantNaam { get; set; }
        public Reservering(int TafelID, DateTime BeginTijd, DateTime EindTijd, int KlantID)
        {

            this.TafelID = TafelID;
            this.BeginTijd = BeginTijd;
            this.EindTijd = EindTijd;
            this.KlantID = KlantID;
        }
        public Reservering (int ReserveringID, int TafelID, DateTime BeginTijd, DateTime EindTijd, int KlantID) : this(TafelID,BeginTijd,EindTijd,KlantID)
        {
            this.ReserveringID = ReserveringID;
        }
        public Reservering(string KlantNaam, int ReserveringID, int TafelID, DateTime BeginTijd, DateTime EindTijd, int KlantID) : this(ReserveringID, TafelID, BeginTijd, EindTijd, KlantID)
        {
            this.KlantNaam = KlantNaam;
        }
    }
}
