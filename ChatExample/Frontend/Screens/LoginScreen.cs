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
    public partial class LoginScreen : UserControl
    {
        // Esto permite tener una única instancia de la pantalla
        // la cual se crea cuando se pide por primera vez
        private static readonly Lazy<LoginScreen> lazy = 
            new Lazy<LoginScreen>(() => new LoginScreen());
        public static LoginScreen Instance { get { return lazy.Value; } }

        private LoginScreen()
        {
            InitializeComponent();
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Global.router.ShowScreen(SignUpScreen.Instance);
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            messageLbl.Text = "";
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            AuthController.Instance.SignIn(username, password, onError: ShowMessage);
        }

        public void ShowMessage(string message)
        {
            messageLbl.Text = message;
        }
    }
}
