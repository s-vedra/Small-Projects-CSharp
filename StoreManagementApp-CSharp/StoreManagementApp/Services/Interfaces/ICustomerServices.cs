using Enums;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICustomerServices
    {
        void BuyProducts(Store store, Product product);
        void RecieveMessageOnPromotion(Product product, Store store);
    }
}
