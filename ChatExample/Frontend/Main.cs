using Frontend.Screens;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frontend
{
    public partial class Main : MaterialForm
    {
        public Main()
        {
            InitializeComponent();
            ShowScreen(new LoginScreen());
        }

        public void ShowScreen(Control screen)
        {
            this.mainPanel.Controls.Clear();
            this.mainPanel.Controls.Add(screen);
        }
    }
}
