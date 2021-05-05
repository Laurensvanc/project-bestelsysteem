using System.Collections.Generic;

namespace ChapooModel
{
    public class MenuName
    {
        public string Name { get; set; } // Drank, Lunch, Diner
        public List<MenuType> menuTypes { get; set; }
        public int MenuId { get; set; }

        public MenuName(string name, int menuId)
        {
            Name = name;
            MenuId = menuId;
            menuTypes = new List<MenuType>();
        }

        public MenuName(int menuId)
        {
            MenuId = menuId;
            menuTypes = new List<MenuType>();
        }
    }
}