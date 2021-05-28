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
        private Platform _platform;

        public MobileMenu(MobileLogin login, Platform platform)
        {
            InitializeComponent();
            _mobileLogin = login;
            _platform = platform;
            LoadUserControl(new BestellingOpnemen(_platform, this));
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_Display.Controls.Clear();
            pnl_Display.Controls.Add(userControl);
        }
    }
}
