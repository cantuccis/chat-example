using System;

namespace BusinessLogic
{
    public class User
    {
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

                if (value.Length < 5)
                    throw new DomainException("Username is too short (minimum length allowed is 5)");

                if (value.Length > 27)
                    throw new DomainException("Username is too long (maximum length allowed is 27)");

                this.username = value;
            }
        }

        // Mantenemos la password privada para que no pueda ser modificada por otros objetos.
        private string Password
        {
            get => password; 
            set
            {
                if (value == null)
                    throw new DomainException("Password is required");

                if (value.Length < 8)
                    throw new DomainException("Password is too short (minimum length allowed is 8)");

                password = value;
            }
        }

        public string Email { get; set; }
        public DateTime CreationDate { get => creationDate; set => creationDate = value; }

        public bool CheckPassword(string password) => this.Password == password;
    }
}