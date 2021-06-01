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
    public partial class MobileHome : Form
    {
        private MobileLogin _mobileLogin;
        private ChoosePlatform _platform;
        private Account _account;


        public MobileHome(MobileLogin login, ChoosePlatform platform,Account account)
        {
            InitializeComponent();
            _mobileLogin = login;
            _platform = platform;
            _account = account;

            LoadUserControl(new BestellingOpnemen(_platform, this));
        }

        private void LoadUserControl(UserControl userControl)
        {
            pnl_Display.Controls.Clear();
            pnl_Display.Controls.Add(userControl);
        }
    }
}
