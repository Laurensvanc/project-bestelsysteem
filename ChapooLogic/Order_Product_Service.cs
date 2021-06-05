using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChapooDal;
using ChapooModel;

namespace ChapooLogic
{
    public class Order_Product_Service
    {
        Order_ProductDAO orderProductDAO = new Order_ProductDAO();
        public List<Order_Product> GetAllOrderProducts()
        {
            try
            {
                List<Order_Product> bestellingen = orderProductDAO.Db_Get_All_Order_Products();
                return bestellingen;
            }
            catch (Exception err)
            {
                throw (err);
            }
        }

        public bool UpdateOrderStatus(Order_Product orderProduct)
        {
            try
            {
                orderProductDAO.Update_Order_Status(orderProduct);
                return true;
            }
            catch (Exception err)
            {
                return false;
                throw (err);
            }
        }
    }
}
