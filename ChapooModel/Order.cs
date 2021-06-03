using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public Bestelling Bestelling { get; set; }
        public string ProductNaam { get; set; }
        public double Prijs { get; set; }
        public int Aantal { get; set; }
        public bool isAlcohol { get; set; }
        public Order(Bestelling Bestelling, string ProductNaam, double Prijs, int Aantal, bool isAlcohol)
        {
            this.Bestelling = Bestelling;
            this.ProductNaam = ProductNaam;
            this.Prijs = Prijs * Aantal;
            this.Aantal = Aantal;
            this.isAlcohol = isAlcohol;
        }
    }
}
