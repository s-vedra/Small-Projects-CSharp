using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class HelperMethods
    {
        public static int Parsing(string text)
        {
            while (true)
            {
                try
                {
                    if (!int.TryParse(text, out int num))
                    {
                        throw new Exception("Invalid input");
                    }
                    else
                    {
                        return num;
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
