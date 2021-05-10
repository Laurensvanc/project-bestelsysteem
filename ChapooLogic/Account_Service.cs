﻿using ChapooDal;
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
    }
}
