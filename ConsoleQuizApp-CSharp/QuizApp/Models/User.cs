using Enums;

namespace Models
{
    public abstract class User
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public User(string name, string lastName, Role role, string username, string password)
        {
            Name = name;
            LastName = lastName;
            Role = role;
            Username = username;
            Password = password;
        }

        public bool CheckUsername(string username)
        {
            if (Username == username)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckPassword(string password)
        {
            if (Password == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string ReturnInfo()
        {
            return $"Full Name: {Name} {LastName}";

        }
    }
}