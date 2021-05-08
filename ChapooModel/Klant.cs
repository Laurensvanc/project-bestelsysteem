using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Klant
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string GeboorteDatum { get; set; }
        public DateTime LaatsteBezoek { get; set; }
        public string Mobiel { get; set; }
        public string HuisTelefoon { get; set; }
        public string Email { get; set; }
        public int KlantID { get; set; }
        public Klant(string Voornaam, string Achternaam, string GeboorteDatum, string Mobiel)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.GeboorteDatum = GeboorteDatum;
            this.Mobiel = Mobiel;
        }
        public Klant (string Voornaam, string Achternaam, string GeboorteDatum, string Mobiel, int KlantID)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.GeboorteDatum = GeboorteDatum;
            this.Mobiel = Mobiel;
            this.KlantID = KlantID;
        }

    }
}
