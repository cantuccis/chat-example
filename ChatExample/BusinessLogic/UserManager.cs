using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class UserManager
    {
        private IList<User> _users;
        public UserManager()
        {
            _users = new List<User>();
        }

        public void SignUp(string username, string password, string email = "")
        {
            if (IsRegistered(username))
                throw new DomainException("User already exists");
            var user = new User(username, password, email);
            _users.Add(user);
        }

        public bool IsRegistered(string username) => _users.Any(u => u.Username == username);

        public User SignIn(string username, string password)
        {
            var user = _users.FirstOrDefault(u => u.Username == username);
            if (user == null)
                throw new DomainException("Invalid credentials");
            if (!user.CheckPassword(password))
                throw new DomainException("Invalid credentials");
            return user;
        }
    }
}