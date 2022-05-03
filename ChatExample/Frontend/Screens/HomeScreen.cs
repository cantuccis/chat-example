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
            /*
             * if (AuthController.Instance.IsUserSignedIn)
            {
                var user = AuthController.Instance.UserSignedIn;
                
]            }
            else
            {

            }
             */
            var chatPanel = new UserControls.ChatPanel.ChatPanel();
            chatPanelContainer.Controls.Add(chatPanel);
        }
    }
}
