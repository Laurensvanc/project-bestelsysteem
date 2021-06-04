using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class BarKeukenBestelling
    {
        public Order Order { get; set; }
        public Bestelling Bestelling { get; set; }
        public Product Product { get; set; }
        public Tafel Tafel { get; set; }
        public string ProductNaam { get; set; }
        public bool IsDrinken { get; set; }
        public string Status { get; set; }
        public int Aantal { get; set; }
        public DateTime Opgenomen { get; set; }

        public BarKeukenBestelling(Order Order, Bestelling Bestelling, Product Product, Tafel Tafel, string productNaam, bool isDrinken, string status, int aantal, DateTime opgenomen)
        {
            this.Order = Order;
            this.Bestelling = Bestelling;
            this.Product = Product;
            this.Tafel = Tafel;
            ProductNaam = productNaam;
            IsDrinken = isDrinken;
            Status = status;
            Aantal = aantal;
            Opgenomen = opgenomen;
        }
    }
}
