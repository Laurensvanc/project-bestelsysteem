using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order_Product
    {
        public Order Order { get; set; }
        public Product Product { get; set; }
        public int Aantal { get; set; }
        public Bestelling Bestelling { get; set; }
        public string Status { get; set; }

        public Order_Product(Product Product, int Aantal)
        {
            this.Product = Product;
            this.Aantal = Aantal;
        }

        public Order_Product(Order order, string status, int aantal,Product product, Bestelling bestelling)
        {
            Order = order;
            Aantal = aantal;
            Status = status;
            Product = product;
            Bestelling = bestelling;
        }
    }
}
