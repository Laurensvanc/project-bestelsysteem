using ChapooLogic;
using ChapooModel;
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
    public partial class MobileLogin : Form
    {
        private ChoosePlatform _platform;

        public MobileLogin(ChoosePlatform platfrom)
        {
            InitializeComponent();
            _platform = platfrom;
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            _platform.Show();
            this.Close();
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
           
            if (txb_gebruikersNaam.Text == "" || txb_wachtwoord.Text == "")
            {
                MessageBox.Show($"Niet alle velden zijn ingevuld.");
                return;
            }

            Account_Service service = new Account_Service();
            Account account = service.LoginAccount(txb_gebruikersNaam.Text);
            

            if (account.Wachtwoord != string.Empty && account.Voornaam != string.Empty)
            {
                if (BCrypt.Net.BCrypt.Verify(txb_wachtwoord.Text, account.Wachtwoord))
                {
                    MobileHome menu = new MobileHome(this, _platform,account);

                    menu.Show();
                    this.Hide();
                    service.UpdateLastLoginAccount(account.Inlognaam);
                }
                else
                {
                    MessageBox.Show($"Wachtwoord is incorrect");
                    lbl_wachtwoord.ForeColor = Color.Red;

                }
            }
            else
            {
                MessageBox.Show($"Wachtwoord of Inlognaam is incorrect");

            }
        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            if (secrettxtbox.Text.ToLower() == "hond")
            {


                if (newwwtxt.Text == herhalingwwtxt.Text)
                {
                    string password = newwwtxt.Text;
                    string encryptedwachtwoord = BCrypt.Net.BCrypt.HashPassword(password);
                    Account_Service service = new Account_Service();

                    if (service.ResetPassword(user2txt.Text, encryptedwachtwoord))
                    {
                        MessageBox.Show("Wachtwoord gereset!");
                    }
                    else
                    {
                        MessageBox.Show("Er is iets fout gegaan!");
                    }

                }
                else
                {
                    MessageBox.Show("Wachtwoorden komen niet overeen!");
                }
            }
            else
            {
                MessageBox.Show("Antwoord op je geheime vraag klopt niet");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txb_gebruikersNaam.Text = user2txt.Text;
            wwresetpnl.Hide();
        }

        private void lbl_wachtwoordReset_Click(object sender, EventArgs e)
        {
            user2txt.Text = txb_gebruikersNaam.Text;
            wwresetpnl.Show();
        }
    }
}
