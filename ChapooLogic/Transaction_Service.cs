using ChapooDal;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Transaction_Service
    {
        private TransactionDAO transactionDAO = new TransactionDAO();

        public List<int> GetTables()
        {
            try
            {
                List<int> tableList = transactionDAO.DB_Get_Tables();
                return tableList;
            }
            catch (Exception ex)
            {
                List<int> tableList = new List<int>();
                return tableList;

                throw new Exception("Chapoo kon niet verbinden met de database");
            }
        }
        public Order_Info GetOrderInfo(int tafelID)
        {
            try
            {
                Order_Info orderInfo = transactionDAO.DB_Get_Order_Info(tafelID);
                return orderInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void AddTransaction()
        {
            try
            {
                transactionDAO.DB_Add_Transaction();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Order> GetOrders(int tafelID)
        {
            try
            {
                List<Order> orderList = transactionDAO.DB_Get_Orders(tafelID);
                return orderList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateTransaction(Transactie transactie)
        {
            try
            {
                return transactionDAO.DB_Update_Transaction(transactie);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
