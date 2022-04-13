
using Models;
using Services;



while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Hello user! Choose your role \n1.Teacher \n2.Student \n3.Exit", Console.ForegroundColor = ConsoleColor.White);
        int choice = HelperMethods.Parsing(Console.ReadLine());
        if (choice == 1)
        {
            Teacher teacher = Service<Teacher>.Login(UsersDB.teachers);
            if (teacher == null)
            {
                Console.WriteLine("Goodbye");
            }
            else
            {
                teacher.ReturnStudents(UsersDB.students);
                Console.ReadLine();
                continue;
            }
        }
        else if (choice == 2)
        {
            Student student = Service<Student>.Login(UsersDB.students);
            if (student == null)
            {
                Console.WriteLine("Goodbye");
            }
            else if (student.FinishedQuiz)
            {
                Console.WriteLine("You already did the test!");
                Console.ReadLine();
                continue;
            }
            else
            {
                Console.WriteLine(student.ReturnPoints());
                Console.WriteLine(student.ReturnInfo());
                Console.WriteLine("Press enter to log out");
                Console.ReadLine();
                continue;
            }
        } else if (choice == 3)
        {
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            throw new Exception("Please choose 1, 2 or 3, press enter to continue");
        }
    }
    catch (Exception msg)
    {
        Console.WriteLine(msg.Message);
        Console.ReadLine();
        continue;
    }
    break;
}


