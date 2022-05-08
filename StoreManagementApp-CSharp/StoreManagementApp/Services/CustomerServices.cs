using Enums;
using Models;
using Services.Interfaces;

namespace Services
{
    public class CustomerServices : ICustomerServices
    {
        public void BuyProducts(Store store, Product product)
        {
            store.RemoveProducts(() => product);
        }
        public void RecieveMessageOnPromotion(Product product, Store store)
        {
            Console.WriteLine("Customers got: ");
            DBUsers.customerList.Where(customer => customer.FavoriteProduct == product).ToList()
                .ForEach(customer => Console.WriteLine($"Hello {customer.Name}! There is a promotion for {product} in {store.Name}"));
        }

    }
}
