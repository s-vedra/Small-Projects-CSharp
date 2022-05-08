using Enums;

namespace Models
{
    public class Store : BaseEntity
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Product CurrentPromotion { get; set; }
        public Store(int id, string name, Product currentPromotion) : base(id)
        {
            Name = name;
            CurrentPromotion = currentPromotion;
        }
        public override string GetInfo()
        {
            return $"Store: {Name} Current Promotion: {CurrentPromotion}";
        }
    }
}