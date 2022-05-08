using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IManagerServices
    {
        void GetMessageBought(Product product, Store store);
        void GetMessagePromotion(Product product, Store store);
        void GetMessageAddedEmployee(Employee seller);
        void GetMessageAddProduct(Product product, Store store);
        void GetMessageRemoveProduct(Product product, Store store);
        void GetMessageForProductCount(Dictionary<Product, int> grouped);
        void GetMessageForEmployeeCount(Dictionary<Store, int> grouped);
    }
}
