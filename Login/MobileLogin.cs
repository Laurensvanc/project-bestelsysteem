﻿using System;
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
            MobileMenu menu = new MobileMenu(this);

            menu.Show();
            this.Hide();
        }
    }
}
