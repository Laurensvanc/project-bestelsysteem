using System.Collections.Generic;

namespace ChapooModel
{
    public class MenuType
    {
        public string Type { get; set; } // Voorgerecht, Nagerecht, Frisdrank, Bieren
        public List<Product> Products { get; set; }
        public int SoortID { get; set; }

        public MenuType(string type, int soortId)
        {
            Type = type;
            Products = new List<Product>();
            SoortID = soortId;
        }

        public MenuType(int soortId)
        {
            SoortID = soortId;
            Products = new List<Product>();
        }
    }
}