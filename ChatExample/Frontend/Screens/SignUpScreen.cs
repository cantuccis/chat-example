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
    public partial class SignUpScreen : UserControl
    {
        private static readonly Lazy<SignUpScreen> lazy =
            new Lazy<SignUpScreen>(() => new SignUpScreen());
        public static SignUpScreen Instance { get { return lazy.Value; } }

        private SignUpScreen()
        {
            InitializeComponent();
        }

        private void orSignInButton_Click(object sender, EventArgs e)
        {
            Global.router.ShowScreen(LoginScreen.Instance);
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            errorLbl.Text = "";
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string email = emailTxt.Text;
            AuthController.Instance.SignUp(username, password, email, onError: ShowErrorMessage);

        }

        private void ShowErrorMessage(string error)
        {
            errorLbl.Text = error;
        }
    }
}
