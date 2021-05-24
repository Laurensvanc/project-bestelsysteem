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
    public partial class MobileMenu : Form
    {
        private MobileLogin _mobileLogin;

        public MobileMenu(MobileLogin login)
        {
            InitializeComponent();
            _mobileLogin = login;
            LoadUserControl(new BestellingOpnemen());
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_Display.Controls.Clear();
            pnl_Display.Controls.Add(userControl);
        }
    }
}
