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
        public List<BarKeukenBestelling> GetAllBarKeukenBestellingen()
        {
            try
            {
                List<BarKeukenBestelling> bestellingen = orderProductDAO.Db_Get_All_BarKeuken_Bestellingen();
                return bestellingen;
            }
            catch (Exception err)
            {
                throw (err);
            }
        }

        public bool UpdateOrderStatus(int orderId, int productId, string status)
        {
            try
            {
                orderProductDAO.Update_Order_Status(orderId, productId, status);
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
