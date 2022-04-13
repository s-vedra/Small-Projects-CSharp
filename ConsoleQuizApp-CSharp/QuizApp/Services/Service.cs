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
                    foreach (T user in list)
                    {
                        if (user.CheckUsername(userUsername))
                        {
                            Console.WriteLine("Enter password");
                            string userPassword = Console.ReadLine();
                            if (user.CheckPassword(userPassword))
                            {
                                Console.WriteLine($"Welcome {user.Role} {user.Name}");
                                return user;
                            }
                            else if (attempt == 0)
                            {

                                throw new ArgumentException("Too many attempts");
                            }
                        }
                        else if (attempt == 0)
                        {

                            throw new ArgumentException("Too many attempts");
                        }

                    }
                    attempt--;
                    throw new Exception("Username or password incorrect");
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