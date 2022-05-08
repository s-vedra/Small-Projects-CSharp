﻿using Enums;
using Models;
using Services.Interfaces;

namespace Services
{
    public class UserServices : IUserServices
    {
        public delegate void PrintUser(Employee employee);
        public delegate Store ReturnStore(Dictionary<Store, int> group);

        public Employee Login(PrintUser print)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter username: ");
                    string username = HelperMethods.CheckString();
                    Console.Write("Enter password: ");
                    string password = HelperMethods.CheckString();
                    Employee user = DBUsers.employeeList.SingleOrDefault(user => user.Username == username && user.Password == password);
                    if (user != null)
                    {
                        print(user);
                        return user;
                    }
                    else
                    {
                        throw new Exception("User not found");
                    }
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    continue;
                }
            }

        }

        public Employee AcceptJobOffer(ReturnStore storeJobOffer)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter username: ");
                    string username = HelperMethods.CheckString();
                    Console.Write("Enter password: ");
                    string password = HelperMethods.CheckString();

                    Role role = Role.Salesman;
                    Store store = storeJobOffer(StoreServices.GetEmployeesCount(DBUsers.employeeList));

                    int id = DBServices<Employee>.ReturnId(DBUsers.employeeList);
                    return new Employee(id, role, username, password)
                    {
                        WorkingStore = store
                    };

                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    continue;
                }

            }
        }

    }
}
