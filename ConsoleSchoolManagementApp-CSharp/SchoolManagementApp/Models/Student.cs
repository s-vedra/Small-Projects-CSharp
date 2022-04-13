namespace Models
{
    public class Student : User, IStudent
    {
        public List<int> Grades = new List<int>();
        public Major Major { get; set; }
        public Student(int id, string name, string lastname, string username, string password, Major major, List<int> grades)
            : base(id, name, lastname, Role.Student, password, username)
        {

            Major = major;
            Grades = grades;
        }

        public void PrintGrades()
        {
            foreach (int grade in Grades)
            {
                Console.WriteLine(grade);
            }

        }
        public float GetAverageGrade()
        {

         return (float)Grades.Sum() / Grades.Count;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Fullname: {FirstName} {LastName} {Major} \nGrades:");
            PrintGrades();
            Console.WriteLine($"Average Grade: {Math.Floor(GetAverageGrade() * 10) / 10}");
        }
    }
}
