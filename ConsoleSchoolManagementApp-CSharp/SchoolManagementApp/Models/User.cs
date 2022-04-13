namespace Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        private string _username { get; set; }
        private string _password { get; set; }

        public User(int id, string name, string lastname,Role role ,string password, string username)
        {
            Id = id;
            FirstName = name;
            LastName = lastname;
            Role = role;
            _password = password;
            _username = username;
        }
        public bool CheckPassword(string password)
        {
            if (_password == password)
            {
                return true;
            }
            return false;
        }
        public bool CheckUsername(string username)
        {
            if (_username == username)
            {
                return true;
            }
            return false;
        }
    }
}
