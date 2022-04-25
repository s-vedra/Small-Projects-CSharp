using Models;

namespace Services
{
    public class StudentService
    {
        public static void StudentLogin()
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

            }
            else
            {
                Console.WriteLine(student.ReturnPoints());
                Console.WriteLine(student.ReturnInfo());
                Console.WriteLine("Press enter to log out");
                Console.ReadLine();

            }
        }
    }
}
