using Models;

namespace Services
{
    public class Service
    {
        public int Parsing(string userInput)
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
        public T Login<T>(List<T> list) where T : User
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