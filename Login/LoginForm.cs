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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CenterToScreen();
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
                    new Menu().Show();

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
    }
}
