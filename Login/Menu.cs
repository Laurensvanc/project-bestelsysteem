using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Menu : Form
    {
        private LoginForm _loginForm;
        public Menu(LoginForm loginForm)
        {
            InitializeComponent();
            btn_closeForm.FlatAppearance.MouseOverBackColor = btn_closeForm.BackColor;
            TimeDisplay();
            _loginForm = loginForm;
        }

        public void TimeDisplay()
        {
            Timer tmr = null;
            StartTimer(tmr);
        }
        private void StartTimer(Timer tmr)
        {
            tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }
        void tmr_Tick(object sender, EventArgs e)
        {
            lbl_timeDisplay.Text = DateTime.Now.ToString("F", CultureInfo.CreateSpecificCulture("nl-NL"));
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
            LoadUserControl(new BarKeukOverzicht());
        }

        private void btn_navHome_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RestaurantOverzicht());
        }

        private void btn_navBestellingen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BestellingOpnemenDesktop());
        }

        private void btn_navRegistreren_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MedewerkerRegistreren());
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            if (!pnl_LogoutBorder.Visible)
            {
                pnl_LogoutBorder.Show();
            }
            else
            {
                pnl_LogoutBorder.Hide();
            }
            
        }
        private void btn_Uitloggen_Click(object sender, EventArgs e)
        {
            _loginForm.Show();
            this.Hide();
        }

        private void btn_Afsluiten_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_navAfrekenen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Afrekenen());
        }

        private void tsm_overzicht_Click(object sender, EventArgs e)
        {
            LoadUserControl(new RestaurantOverzicht());
        }

        private void tsm_bestellen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BestellingOpnemenDesktop());
        }

        private void tsm_afrekenen_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Afrekenen());
        }

        private void tsm_barKeuken_Click(object sender, EventArgs e)
        {
            LoadUserControl(new BarKeukOverzicht());
        }

        private void tsm_account_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MedewerkerRegistreren());
        }

        private void tsm_voorraad_Click(object sender, EventArgs e)
        {
            LoadUserControl(new VoorraadOverview());
        }
    }
}
