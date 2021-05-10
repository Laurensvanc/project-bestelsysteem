using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Account
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Inlognaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public int Telefoonnummer { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public int Manager { get; set; }
        public int Chef { get; set; }
        public int Bediening { get; set; }
        public int Keuken { get; set; }
        public int Sommelier { get; set; }
        public int Maitre { get; set; }
        public int Bar { get; set; }
        public Account(string Voornaam, string Achternaam, string Inlognaam, DateTime GeboorteDatum, int Telefoonnummer, string Email, string Wachtwoord, int Manager, int Chef, int Bediening, int Keuken, int Sommelier, int Maitre, int Bar)
        {
            this.Voornaam = Voornaam;
            this.Achternaam = Achternaam;
            this.Inlognaam = Inlognaam;
            this.GeboorteDatum = GeboorteDatum;
            this.Telefoonnummer = Telefoonnummer;
            this.Email = Email;
            this.Wachtwoord = Wachtwoord;
            this.Manager = Manager;
            this.Chef = Chef;
            this.Bediening = Bediening;
            this.Keuken = Keuken;
            this.Sommelier = Sommelier;
            this.Maitre = Maitre;
            this.Bar = Bar;
        }
    }
}
