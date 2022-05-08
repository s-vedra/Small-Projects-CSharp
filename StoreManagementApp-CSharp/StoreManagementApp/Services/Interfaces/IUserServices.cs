using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Services.UserServices;

namespace Services.Interfaces
{
    public interface IUserServices
    {
        Employee Login(PrintUser print);
        Employee AcceptJobOffer(ReturnStore storeJobOffer);
    }
}
