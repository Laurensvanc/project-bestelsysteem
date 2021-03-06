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
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public Account LoginAccount(string account)
        {
            try
            {
                Account account1 =  accountDAO.GetAccount(account);
                
                return account1;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
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

        public Account loginPincode(int code)
        {
            try
            {
               string inlognaam = accountDAO.loginPincode(code);
               return accountDAO.GetAccount(inlognaam);
            }catch (Exception e)
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
                
                throw;
            }
        }
        public bool CheckExistingAccount(string name)
        {
            try
            {
                return accountDAO.Db_Check_Existing_Account(name);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool checkanswer(string v,string i)
        {

            return accountDAO.checkanswer(v,i);
        }
        public List<int> GetPincodes()
        {
            return accountDAO.Db_Get_All_Pincodes();
        }
    }
}
