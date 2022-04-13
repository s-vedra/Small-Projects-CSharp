namespace Models
{
    public abstract class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User(int id, string name, string lastname,Role role ,string password, string username)
        {
            Id = id;
            FirstName = name;
            LastName = lastname;
            Role = role;
            Password = password;
            Username = username;
        }
    }
}
