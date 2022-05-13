using Enums;
using Models;
using Services.Interfaces;

namespace Services
{
    public static class HelperMethods
    {
        //private static ILoggingServices loggingServices = new LoggingServices();
        public static int Parsing(this string message)
        {
            while (true)
            {
                try
                {
                    if (!int.TryParse(message, out int num))
                    {
                        throw new ExceptionServices("User entered invalid message type");
                    }
                    else
                    {
                        return num;
                    }
                }
                catch (ExceptionServices)
                {
                    Console.WriteLine("Bad request, try again");
                    return 0;
                }
            }
        }

        public static string CheckString()
        {
            while (true)
            {
                try
                {
                    string? message = Console.ReadLine();
                    if (!string.IsNullOrEmpty(message))
                    {
                        return message;
                    }
                    else
                    {
                        throw new ExceptionServices("User left an empty field");
                    }
                }
                catch (ExceptionServices)
                {
                    Console.WriteLine("Field mustn't be empty");
                    continue;
                }
            }


        }

        public static void ListProducts()
        {
            List<Product> products = new List<Product>()
            {
               Product.CPU,
               Product.Motherboard,
               Product.GPU,
               Product.Peripherals,
               Product.Coolers,
               Product.RAM,
               Product.PSU
            };

            for (int i = 0; i<products.Count;i++)
            {
                Console.WriteLine($"Id: {i+1} Product: {products[i]}");
            }
        }

        public static void MainMenu()
        {
            Console.WriteLine("Press enter to go back to the Main Menu");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
