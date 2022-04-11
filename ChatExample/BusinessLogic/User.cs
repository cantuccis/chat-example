using System;

namespace BusinessLogic
{
    public class User
    {
        public static readonly int MinimumUsernameLength = 5;
        public static readonly int MaximumUsernameLength = 27;
        public static readonly int MinimumPasswordLength = 8;

        private string username;
        private string password;
        private DateTime creationDate;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = password;
            this.CreationDate = DateTimeProvider.Now;
        }

        public User(string username, string password, string email) : this(username, password) // Usa el constructor de arriba y le agrega el mail   
        {
            this.Email = email;
        }

        public string Username
        {
            get => username; private set
            {
                if (value == null)
                    throw new DomainException("Username is required");

                if (value.Length < MinimumUsernameLength)
                    throw new DomainException($"Username is too short (minimum length allowed is {MinimumUsernameLength})");

                if (value.Length > MaximumUsernameLength)
                    throw new DomainException($"Username is too long (maximum length allowed is {MaximumUsernameLength})");

                this.username = value;
            }
        }

        public string Email { get; set; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }

        public bool CheckPassword(string password) => this.Password == password;


        // Mantenemos la password privada para que no pueda ser modificada por otros objetos.
        private string Password
        {
            get => password;
            set
            {
                if (value == null)
                    throw new DomainException("Password is required");

                if (value.Length < MinimumPasswordLength)
                    throw new DomainException($"Password is too short (minimum length allowed is {MinimumPasswordLength})");

                password = value;
            }
        }

        public override bool Equals(object obj)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var user = (User)obj;

            return user.username == this.username;
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }

    }
}