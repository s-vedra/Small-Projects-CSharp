using Service;

namespace Models
{
    public static class UserService<T>  where T : User
    {
        
        public static T Login(List<T> users) 
        {
            int attempt = 3;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    foreach (T user in users)
                    {
                        if (user.Username == username && !string.IsNullOrEmpty(username))
                        {
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            if (user.Password == password && !string.IsNullOrEmpty(password))
                            {
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
                    throw new Exception("Username or password is incorrect");
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
