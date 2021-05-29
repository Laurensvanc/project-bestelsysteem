using ChapooDal;
using ChapooModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooLogic
{
    public class Account_Service
    {
        AccountDAO accountDAO = new AccountDAO();
        public bool AddAccount(Account account)
        {
            try
            {
                accountDAO.RegisterAccount(account);
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public string LoginAccount(string account)
        {
            try
            {
                string ww =  accountDAO.LoginAccount(account);
                
                return ww;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public bool UpdateLastLoginAccount(string account)
        {
            try
            {
                 accountDAO.UpdateLastLoginAccount(account);

                return true;
            }
            catch (Exception e)
            {
                
                throw;
            }
        }

        public bool ResetPassword(string user2txt, string encryptedwachtwoord)
        {
            try
            {
                accountDAO.ResetPassword(user2txt,encryptedwachtwoord);

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
