using Models;

namespace Services
{
    public static class Service<T> where T : User
    {
        public static T Login(List<T> list) 
        {
            int attempt = 2;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string userUsername = Console.ReadLine();
                    Console.WriteLine("Enter password");
                    string userPassword = Console.ReadLine();
                    T user = DBServices<T>.ReturnEntity(list, userUsername, userPassword);
                    if (attempt == 0)
                    {
                        
                        throw new ArgumentException("Too many attempts");
                    }
                    else if (user == null)
                    {
                        attempt--;
                        throw new Exception("Username or password incorrect");
                    }
                    else
                    {
                        return user;
                    }
                }
                catch (ArgumentException msg)
                {
                    Console.WriteLine(msg.Message);
                    return null;
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