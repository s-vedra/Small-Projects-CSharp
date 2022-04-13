
using Models;
using Services;



Service service = new Service();
while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Hello user! Choose your role \n1.Teacher \n2.Student \n3.Exit", Console.ForegroundColor = ConsoleColor.White);
        int choice = service.Parsing(Console.ReadLine());
        if (choice == 1)
        {

            Teacher teacher = service.Login<Teacher>(UsersDB.teachers);
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
            Student student = service.Login<Student>(UsersDB.students);
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

                int points = student.ReturnPoints();
                Console.WriteLine(points);
                student.Grade = student.ReturnGrade(points);
                Console.WriteLine($"{student.Name}'s grade is {student.Grade}");
                student.FinishedQuiz = true;
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


