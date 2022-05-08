using Enums;

namespace Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{Name} {LastName}";
            }
        }
        public Product FavoriteProduct { get; set; }
        public Customer(int id, string name, string lastName, Product product) 
            : base(id)
        {
            Name = name;
            LastName = lastName;
            FavoriteProduct = product;
        }
        public override string GetInfo()
        {
            return $"{FullName} {FavoriteProduct}";
        }

    }
}
