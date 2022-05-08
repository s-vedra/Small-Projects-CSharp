using Enums;

namespace Models
{
    public class Employee : BaseEntity
    {

        public string Username { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Store WorkingStore { get; set; }
        public List<Store> ManagingStores { get; set; }


        public Employee(int id, Role role, string username, string password)
            : base(id)
        {
            Username = username;
            Role = role;
            Password = password;
        }

        public override string GetInfo()
        {
            if (WorkingStore != null)
            {
                return $"{Username} - {Role} works in {WorkingStore.Name}";
            }
            else
            {
                Console.Write($"{Username} - {Role} in ");
                foreach (Store store in ManagingStores)
                {
                    Console.Write($"{store.Name} ");
                }
                return "";
            }

        }
    }
}
