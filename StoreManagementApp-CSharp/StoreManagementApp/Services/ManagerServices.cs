using Enums;
using Models;
using Services.Interfaces;

namespace Services
{
    public class ManagerServices : IManagerServices
    {
        public void GetMessageBought(Product product, Store store)
        {
            Console.WriteLine("Manager got the following message: ");
            Console.WriteLine($"{product} was bought from {store.Name}");
        }
        public void GetMessagePromotion(Product product, Store store)
        {
            Console.WriteLine("Manager got the following message: ");
            Console.WriteLine($"There is a promotion for {product} in {store.Name}");
        }
        public void GetMessageAddedEmployee(Employee seller)
        {
            Console.WriteLine("Manager got the following message: ");
            Console.WriteLine($"We have a new employee: {seller.Username}");
        }
        public void GetMessageAddProduct(Product product, Store store)
        {
            Console.WriteLine("Manager got the following message: ");
            Console.WriteLine($"{product} was added");
        }
        public void GetMessageRemoveProduct(Product product, Store store)
        {
            Console.WriteLine("Manager got the following message: ");
            Console.WriteLine($"{product} was removed");
        }
        public void GetMessageForProductCount(Dictionary<Product, int> grouped)
        {
            Console.Clear();
            foreach (var product in grouped)
            {
                Console.WriteLine($"{product.Key} - currently has {product.Value} items");
            }
        }
        public void GetMessageForEmployeeCount(Dictionary<Store, int> grouped)
        {
            foreach (var employee in grouped)
            {
                Console.WriteLine($"{employee.Key.Name} - currently has {employee.Value} employees");
            } 
        }

    }
}