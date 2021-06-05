using System;
using System.Collections.Generic;
using System.Text;

namespace ChapooModel
{
    public class Reservering
    {
        public int ReserveringID { get; set; }
        public Tafel Tafel { get; set; }
        public DateTime BeginTijd { get; set; }
        public DateTime EindTijd { get; set; }
        public Klant Klant { get; set; }
        public int AantalPersonen { get; set; }

        public string KlantNaam { get; set; }

        public Reservering(int ReserveringID)
        {
            this.ReserveringID = ReserveringID;
        }
        public Reservering(Tafel Tafel, DateTime BeginTijd, DateTime EindTijd, Klant Klant, int AantalPersonen)
        {
            this.Klant = new Klant(Klant.Voornaam, Klant.Achternaam, Klant.GeboorteDatum, Klant.Mobiel, Klant.KlantID);
            this.Tafel = Tafel;
            this.BeginTijd = BeginTijd;
            this.EindTijd = EindTijd;
            this.AantalPersonen = AantalPersonen;
        }
        public Reservering (int ReserveringID, Tafel Tafel, DateTime BeginTijd, DateTime EindTijd, Klant Klant, int AantalPersonen) : this(Tafel,BeginTijd,EindTijd,Klant,AantalPersonen)
        {
            this.ReserveringID = ReserveringID;
        }
        public Reservering(string KlantNaam, int ReserveringID, Tafel Tafel, DateTime BeginTijd, DateTime EindTijd, Klant Klant, int AantalPersonen) : this(ReserveringID, Tafel, BeginTijd, EindTijd, Klant, AantalPersonen)
        {
            this.KlantNaam = KlantNaam;
        }
    }
}
