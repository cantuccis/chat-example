using BusinessLogic;
using Frontend.Screens;
using Frontend.UserControls.InAppNotification;
using Frontend.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frontend.Controllers
{
    internal class AuthController
    {
        private static readonly Lazy<AuthController> lazy =
            new Lazy<AuthController>(() => new AuthController());
        public static AuthController Instance { get { return lazy.Value; } }

        private AuthController()
        {
            _userManager = new UserManager();
        }

        private UserManager _userManager;
        private User _user;

        public bool IsUserSignedIn { get => _user != null; }
        public User UserSignedIn { get => _user; }

        public void SignIn(string username, string password, OnError onError = null)
        {
            try
            {
                if (!IsUserSignedIn)
                {
                    _user = _userManager.SignIn(username, password);
                    Global.router.ShowScreen(HomeScreen.Instance);
                }
            }
            catch (DomainException ex)
            {
                InAppNotification.Instance.ShowError(ex.Message);
                onError?.Invoke(ex.Message);
            }
        }

        public void SignUp(string username, string password, string email, Bitmap profileImage = null, OnError onError = null)
        {
            try
            {
                _userManager.SignUp(username, password, email, profileImage);
                InAppNotification.Instance.ShowMessage("Success! You can sign in now.");
                Global.router.ShowScreen(LoginScreen.Instance);
            }
            catch (DomainException ex)
            {
                InAppNotification.Instance.ShowError(ex.Message);
                onError?.Invoke(ex.Message);
            }
        }

        public void LogOut()
        {
            _user = null;
            Global.router.ShowScreen(LoginScreen.Instance);
        }
    }
}
