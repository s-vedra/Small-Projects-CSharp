using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public static class UsersDB
    {
        public static List<Student> students = new List<Student>()
        {
            new Student("Bob", "Bobsky", "BobTheStudent","bob123456"),
            new Student("Adam", "Adamy","AdamTheStudent","adam123456"),
            new Student("Jony", "Bonbony", "JonyTheStudent","jony123456"),
            new Student("Stella", "Strella", "StellaTheStudent","stella123456"),   

        };

        public static List<Teacher> teachers = new List<Teacher>()
        {
            new Teacher("John", "Johnsky","TrainerJohn","trainerJohn12345")
        };
    }
}
