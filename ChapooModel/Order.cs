using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int Aantal { get; set; }
    
        public Order(int orderId, int aantal)
        {
            OrderID = orderId;
            Aantal = aantal;
        }
    }
}
