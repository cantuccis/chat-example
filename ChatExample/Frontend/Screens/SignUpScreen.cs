﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend.Screens
{
    public partial class SignUpScreen : UserControl
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }

        private void orSignInButton_Click(object sender, EventArgs e)
        {
            Global.router.ShowScreen(new LoginScreen());
        }
    }
}