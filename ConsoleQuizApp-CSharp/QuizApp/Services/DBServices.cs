using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class DBServices<T> where T : User
    {
        public static T ReturnEntity(List<T> list, string username, string password)
        {
            return list.SingleOrDefault(user => user.CheckPassword(password) && user.CheckUsername(username));
        }
    }
}
