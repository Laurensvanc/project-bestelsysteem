using ChapooModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ChapooDAL
{
    public class MenuDAO : Base
    {
        public List<MenuName> Db_Get_All_Menus()
        {
            string query = "USE dbchapoo202104 SELECT DISTINCT P.ProductID, P.ProductNaam, P.Prijs, P.InkoopPrijs, P.Aantal, P.IsAlcohol, P.IsDrinken, M.Naam, MPS.Soort, MPS.SoortID, M.MenuID FROM menu_Product AS MP, Product AS P, Menu AS M, Menu_ProductSoort AS MPS WHERE MP.ProductID = P.ProductID AND MP.MenuID = M.MenuID AND MP.SoortID = MPS.SoortID; ";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void ChangeMenuItem(MenuName menu)
        {
            // Data gets changed in database
            string query = "USE dbchapoo202104 INSERT INTO menu_product(MenuID, ProductID, SoortID) VALUES(@MenuID, @ProductID, @SoortID); ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MenuID", menu.MenuId);
            sqlParameters[1] = new SqlParameter("@ProductID", menu.MenuTypes[0].Products[0].ProductId);
            sqlParameters[2] = new SqlParameter("@SoortID", menu.MenuTypes[0].SoortID);

            ExecuteEditQuery(query, sqlParameters);
        }

        public void RemoveMenuItem(MenuName menu)
        {
            // Data gets changed in database
            string query = "USE dbchapoo202104 DELETE FROM Menu_Product WHERE MenuID = @MenuID AND ProductID = @ProductID AND SoortID = @SoortID; ";

            // Setting the parameters from the parameter order
            SqlParameter[] sqlParameters = new SqlParameter[3];

            sqlParameters[0] = new SqlParameter("@MenuID", menu.MenuId);
            sqlParameters[1] = new SqlParameter("@ProductID", menu.MenuTypes[0].Products[0].ProductId);
            sqlParameters[2] = new SqlParameter("@SoortID", menu.MenuTypes[0].SoortID);

            ExecuteEditQuery(query, sqlParameters);
        }

        private List<MenuName> ReadMenuTables(DataTable dataTable)
        {
            List<MenuName> menus = new List<MenuName>();
            string menuName;
            string menuType;

            // Check if datatable is null
            if (dataTable == null)
            {
                throw new Exception("Datatable is null");
            }
            foreach (DataRow dr in dataTable.Rows)
            {
                Product product = new Product
                    (
                    (int)dr["ProductID"],
                    (String)dr["ProductNaam"],
                    (double)dr["Prijs"],
                    (double)dr["InkoopPrijs"],
                    (int)dr["Aantal"],
                    (bool)dr["IsAlcohol"],
                    (bool)dr["IsDrinken"]
                    );
                menuName = (String)dr["Naam"];
                menuType = (String)dr["Soort"];

                if (!menus.Exists(m => m.Name == menuName)) // if menu name doesnt exist make menu
                {
                    MenuName menu = new MenuName(menuName, (int)dr["MenuID"]);
                    menus.Add(menu);
                }
                // if doesnt exist dont do anything because it already exists
                foreach (MenuName m in menus) // foreach menu
                {
                    if (m.Name == menuName) // check for menu name if match
                    {
                        if (!m.MenuTypes.Exists(mt => mt.Type == menuType)) // if menutype doesnt exist in menu make menuType and add product
                        {
                            MenuType type = new MenuType(menuType, (int)dr["SoortID"]);
                            type.Products.Add(product);
                            m.MenuTypes.Add(type);
                        }
                        else // else search for menutype and add
                        {
                            foreach (MenuType mt in m.MenuTypes)
                            {
                                if (mt.Type == menuType)
                                {
                                    mt.Products.Add(product);
                                }
                            }
                        }
                    }
                }
            }

            return menus;
        }
    }
}