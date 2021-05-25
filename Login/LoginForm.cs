using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
using ChapooLogic;

namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void inlogbtn_Click(object sender, EventArgs e)
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
                    new Menu().Show();
                    this.Hide();
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
    }
}
