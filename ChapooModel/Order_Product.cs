using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order_Product
    {
        public Product Product { get; set; }
        public int Aantal { get; set; }
        public Order_Product(Product Product, int Aantal)
        {
            this.Product = Product;
            this.Aantal = Aantal;
        }
    }
}
