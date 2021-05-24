using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            btn_closeForm.FlatAppearance.MouseOverBackColor = btn_closeForm.BackColor;

            //pnl_Reserveringen.Controls.Add((new RestaurantOverzicht()).Controls[0]);
            //pnl_Reserveringen.Controls.Add((new RestaurantOverzicht()).Controls[1]);
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_navReserveringen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RestaurantOverzicht());
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_Display.Controls.Clear();
            pnl_Display.Controls.Add(userControl);
        }

        private void btn_navBarKeuken_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RestaurantOverzicht());
        }

        private void btn_navHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RestaurantOverzicht());
        }

        private void btn_navBestellingen_Click(object sender, EventArgs e)
        {

        }
    }
}
