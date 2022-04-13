
using Models;
using Service;

while (true)
{
    try
    {
        Console.WriteLine("Hello user, please choose your role \n1.Teacher \n2.Student \n3.Exit");
        int answer = HelperMethods.Parsing(Console.ReadLine());
        if (answer == 1)
        {
            Services<Teacher>.TeacherLogin();
        }
        else if (answer == 2)
        { 
            Services<Student>.StudentLogin();
        } else if (answer == 3)
        {
            Console.Clear();
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            throw new Exception("Please choose 1, 2 or 3");
        }
    }
    catch (Exception msg)
    {
        Console.Clear();
        Console.WriteLine(msg.Message);
        continue;
    }
    break;
}


