using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order_Product
    {
        public int ProductID { get; set; }
        public int Aantal { get; set; }
        public Order_Product(int ProductID, int Aantal)
        {
            this.ProductID = ProductID;
            this.Aantal = Aantal;
        }
    }
}
