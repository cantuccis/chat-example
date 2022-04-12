using BusinessLogic;
using Frontend.Screens;
using Frontend.Util;
using System;
using System.Collections.Generic;
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

        public void SignIn(string username, string password, OnError errorCallback)
        {
            try
            {
                if (!IsUserSignedIn)
                {
                    _user = _userManager.SignIn(username, password);
                }
            }
            catch (DomainException ex)
            {
                errorCallback(ex.Message);
            }
        }

        public void SignUp(string username, string password, string email, OnError errorCallback)
        {
            try
            {
                _userManager.SignUp(username, password);
                Global.router.ShowScreen(LoginScreen.Instance);
            }
            catch (DomainException ex)
            {
                errorCallback(ex.Message);
            }
        }

    }
}
