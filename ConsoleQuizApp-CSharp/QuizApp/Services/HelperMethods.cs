using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class HelperMethods
    {
        public static int Parsing(string userInput)
        {
            while (true)
            {
                try
                {
                    if (!int.TryParse(userInput, out int input))
                    {
                        throw new Exception("Invalid input");
                    }
                    else
                    {
                        return input;
                    }
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    return 0;

                }
            }
        }
    }
}
