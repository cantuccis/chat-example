using Frontend.Controllers;
using System;
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
    public partial class HomeScreen : UserControl
    {
        private static readonly Lazy<HomeScreen> lazy =
            new Lazy<HomeScreen>(() => new HomeScreen());
        public static HomeScreen Instance { get { return lazy.Value; } }

        public HomeScreen()
        {
            InitializeComponent();
            if (AuthController.Instance.IsUserSignedIn)
            {
                var user = AuthController.Instance.UserSignedIn;
                helloLbl.Text = $"Heeey {user.Username}, nothing to do here yet, work in progress...";
            }
            else
            {
                helloLbl.Text = "Who the hell are you and how did you get in here!?";
            }
        }
    }
}
