using Enums;

namespace Models
{
    public class Teacher : User, ITeacher
    {
        public Teacher(string name, string lastName, string username, string password)
           : base(name, lastName, Role.Teacher, username, password)
        {

        }

        public void ReturnStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                if (student.FinishedQuiz)
                {
                    Console.WriteLine($"{student.ReturnInfo()}", Console.ForegroundColor = ConsoleColor.Green);
                }
                else if (!student.FinishedQuiz)
                {
                    Console.WriteLine($"{student.ReturnInfo()}", Console.ForegroundColor = ConsoleColor.Red);
                }
            }
        }
    }
}
