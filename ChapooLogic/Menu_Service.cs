using ChapooDAL;
using ChapooModel;
using System;
using System.Collections.Generic;

namespace ChapooLogic
{
    public class Menu_Service
    {
        private readonly MenuDAO _menuDao = new MenuDAO();

        public List<MenuName> GetMenus()
        {
            try
            {
                List<MenuName> menus = _menuDao.Db_Get_All_Menus();
                return menus;
            }
            catch (Exception)
            {
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
                _menuDao.ChangeMenuItem(menuName);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void RemoveMenu(MenuName menuName)
        {
            try
            {
                _menuDao.RemoveMenuItem(menuName);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}