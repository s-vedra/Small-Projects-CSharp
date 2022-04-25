using Models;

namespace Services
{
    public static class TeacherService
    {
        public static void TeacherLogin()
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

            }
        }
    }
}
