using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Menu_Service
    {
        private MenuDAO menuDAO = new MenuDAO();
        public List<MenuName> GetMenus()
        {
            try
            {
                List<MenuName> menus = menuDAO.Db_Get_All_Menus();
                return menus;
            }
            catch (Exception e)
            {
                //ErrorText = e.Message;
                //Error = true;
                // throw new Exception(e.Message);
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<MenuName> menus = new List<MenuName>();
                MenuName m = new MenuName("ERROR", 404);
                menus.Add(m);

                return menus;
            }
        }
        public void ChangeMenu(MenuName menuName)
        {
            try
            {
                menuDAO.ChangeMenuItem(menuName);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void RemoveMenu(MenuName menuName)
        {
            try
            {
                menuDAO.RemoveMenuItem(menuName);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
