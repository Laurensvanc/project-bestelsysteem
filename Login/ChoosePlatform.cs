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
    public partial class ChoosePlatform : Form
    {
        public ChoosePlatform()
        {
            InitializeComponent();
        }

        private void btn_desktop_Click(object sender, EventArgs e)
        {
            DesktopLogin loginForm = new DesktopLogin(this);

            loginForm.Show();
            this.Hide();
        }

        private void btn_mobiel_Click(object sender, EventArgs e)
        {
            MobileLogin mobileLogin = new MobileLogin(this);

            mobileLogin.Show();
            this.Hide();
        }

        private void btn_closeForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
