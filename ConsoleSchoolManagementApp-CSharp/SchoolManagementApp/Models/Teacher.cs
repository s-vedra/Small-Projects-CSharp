namespace Models
{
    public class Teacher : User, ITeacher
    {

        public Teacher(int id, string name, string lastname, string username, string password)
            : base(id, name, lastname, Role.Teacher, password, username)
        {
        }

        public void BestAverageStudents()
        {
            foreach (Student student in UsersDB.students)
            {
                if (student.GetAverageGrade() > 8.50)
                {
                    student.PrintInfo();
                    Console.WriteLine("=======================");
                }
            }
        }

        public float ReturnMaxAverageMajor(Major name)
        {
            float major = 0;
            int count = 0;
            foreach (Student student in UsersDB.students)
            {


                if (student.Major == name)
                {
                    count++;
                    major += student.GetAverageGrade();

                }

            }
            if (count == 0)
            {
                return 0;
            }
            else
            {
                return (float)(Math.Floor(major / count * 10) / 10);
            }
        }

        public Student SearchStudent(int index)
        {
            foreach (Student student in UsersDB.students)
            {
                if (student.Id == index)
                {
                    return student;
                }
            }
            return null;
        }

        public void SortStudents()
        {
            UsersDB.students.Sort((x, y) => string.Compare(x.FirstName, y.FirstName));
            foreach (Student student in UsersDB.students)
            {

                student.PrintInfo();
                Console.WriteLine("=======================");

            }
        }
    }
}
