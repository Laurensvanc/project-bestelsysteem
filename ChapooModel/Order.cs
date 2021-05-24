using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public int BestellingID { get; set; }
        public string ProductNaam { get; set; }
        public double Prijs { get; set; }
        public int Aantal { get; set; }
        public Order(int BestellingID, string ProductNaam, double Prijs, int Aantal)
        {
            this.BestellingID = BestellingID;
            this.ProductNaam = ProductNaam;
            this.Prijs = Prijs * Aantal;
            this.Aantal = Aantal;
        }
    }
}
