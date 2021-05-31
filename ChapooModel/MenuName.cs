using System.Collections.Generic;

namespace ChapooModel
{
    public class MenuName
    {
        public string Name { get; set; } // Drank, Lunch, Diner
        public List<MenuType> MenuTypes { get; set; }
        public int MenuId { get; set; }

        public MenuName(string name, int menuId)
        {
            Name = name;
            MenuId = menuId;
            MenuTypes = new List<MenuType>();
        }

        public MenuName(int menuId)
        {
            MenuId = menuId;
            MenuTypes = new List<MenuType>();
        }
    }
}