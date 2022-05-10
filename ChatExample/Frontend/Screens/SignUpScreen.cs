using Frontend.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private Bitmap selectedImage;

        private void orSignInButton_Click(object sender, EventArgs e)
        {
            Global.router.ShowScreen(LoginScreen.Instance);
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;
            string email = emailTxt.Text;
            AuthController.Instance.SignUp(username, password, email, selectedImage);

        }

        private void addProfileImageBtn_Click(object sender, EventArgs e)
        {
            using OpenFileDialog pictureFileDialog = new OpenFileDialog();
            pictureFileDialog.Title = "Open Image";
            pictureFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (pictureFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new Bitmap(pictureFileDialog.FileName);
                profilePictureImage.Image = selectedImage;
            }
        }
    }
}
