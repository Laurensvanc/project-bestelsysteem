using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RestaurantOverzicht());
            //Application.Run(new Afrekenen());
            //Application.Run(new MedewerkerRegistreren());
            //Application.Run(new LoginForm());
            //Application.Run(new MenuOverview());
            //Application.Run(new BestellingOpnemen());
        }
    }
}
