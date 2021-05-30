using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using BCrypt.Net;
using ChapooLogic;

namespace Login
{
    public partial class DesktopLogin : Form
    {
        ChoosePlatform _platform = new ChoosePlatform();
        public DesktopLogin(ChoosePlatform platform)
        {
            InitializeComponent();
            CenterToScreen();
            _platform = platform;
        }

        private void Inlogbtn_Click(object sender, EventArgs e)
        {
            if (usertxt.Text == "" || wwtxt.Text == "")
            {
                MessageBox.Show($"Niet alle velden zijn ingevuld.");
                return;
            }
            
            Account_Service service = new Account_Service();
            string encryptedww = service.LoginAccount(usertxt.Text);

            if (encryptedww != string.Empty)
            {
                if (BCrypt.Net.BCrypt.Verify(wwtxt.Text, encryptedww)) { 
                    new DesktopHome(this).Show();
                    usertxt.Clear();
                    wwtxt.Clear();
                    usertxt.Select();
                    this.Hide();
                    service.UpdateLastLoginAccount(usertxt.Text);
                }
                else
                {
                    MessageBox.Show($"Wachtwoord is incorrect");
                    wwlbl.ForeColor = Color.Red;

                }
            }
            else {
                MessageBox.Show($"Wachtwoord of Inlognaam is incorrect");

            }
        }

        
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void wwtxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Inlogbtn_Click(sender,e);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            user2txt.Text = usertxt.Text;
            pnlpassword.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            usertxt.Text = user2txt.Text;

            pnlpassword.Hide();

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
                    if(service.ResetPassword(user2txt.Text, encryptedwachtwoord))
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

        private void btn_return_Click(object sender, EventArgs e)
        {
            _platform.Show();
            this.Close();
        }
    }
}
