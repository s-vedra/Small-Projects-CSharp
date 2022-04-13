namespace Models
{
    public static class UserService<T> where T : User
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
                    Console.WriteLine("Enter password");
                    string password = Console.ReadLine();
                    T user = users.SingleOrDefault(user => user.CheckUsername(username) && user.CheckPassword(password));
                    if (attempt == 0)
                    {
                        throw new ArgumentException("Too many attempts");
                    }
                    else if (user == null)
                    {
                        attempt--;
                        throw new Exception("Username or password is incorrect");
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
