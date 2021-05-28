using ChapooLogic;
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
        private Platform _platform;

        public MobileLogin(Platform platfrom)
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
            string encryptedww = service.LoginAccount(txb_gebruikersNaam.Text);

            if (encryptedww != string.Empty)
            {
                if (BCrypt.Net.BCrypt.Verify(txb_wachtwoord.Text, encryptedww))
                {
                    MobileMenu menu = new MobileMenu(this);

                    menu.Show();
                    this.Hide();
                    service.UpdateLastLoginAccount(txb_gebruikersNaam.Text);
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
    }
}
