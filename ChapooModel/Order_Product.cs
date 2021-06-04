using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order_Product
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Aantal { get; set; }
        public string Status { get; set; }
        public Product Product { get; set; } 
        public Bestelling Bestelling { get; set; }

        public Order_Product(int ProductID, int Aantal)
        {
            this.ProductID = ProductID;
            this.Aantal = Aantal;
        }

        public Order_Product(int orderId, int productId, int aantal)
        {
            OrderID = orderId;
            ProductID = productId;
            Aantal = aantal;
        }

        public Order_Product(int orderId,string status, int aantal,Product product, Bestelling bestelling)
        {
            OrderID = orderId;
            Aantal = aantal;
            Status = status;
            Product = product;
            Bestelling = bestelling;
        }
    }
}
