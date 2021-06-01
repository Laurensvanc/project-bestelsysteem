using ChapooModel;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Login
{
    public partial class DesktopHome : Form
    {
        private DesktopLogin _loginForm;
        private readonly Account _account;

        public DesktopHome(DesktopLogin loginForm, Account account)
        {
            InitializeComponent();
            
            btn_closeForm.FlatAppearance.MouseOverBackColor = btn_closeForm.BackColor;
            TimeDisplay();

            _loginForm = loginForm;
            _account = account;
            lbl_username.Text = account.Voornaam + " " + account.Achternaam;
            if (_account.Manager == 1)
            {
                administratieToolStripMenuItem.Visible = true;
            }
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

        private void tmr_Tick(object sender, EventArgs e)
        {
            lbl_timeDisplay.Text = DateTime.Now.ToString("F", CultureInfo.CreateSpecificCulture("nl-NL"));
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
            LoadUserControl(new BestellingOpnemenDesktop(_account));
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
            LoadUserControl(new BestellingOpnemenDesktop(_account));
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

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new MenuOverview());
        }
    }
}