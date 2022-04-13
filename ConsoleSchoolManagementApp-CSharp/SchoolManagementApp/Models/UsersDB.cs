namespace Models
{
    public static class UsersDB
    {
        public static List<Student> students = new List<Student>()
        {
              new Student(15125,"Bob", "Bobsky", "BobTheStudent", "bob123456", Major.Arts, new List<int>() { 10, 10, 10 }),
              new Student(15126,"Karl", "Karly", "KarlTheStudent","karl123456",Major.Arts,new List<int>(){9,6,8}),
              new Student(15127,"Ivan", "Ivsky", "IvanTheStudent","ivan123456",Major.Arts,new List<int>(){9,9,10}),
              new Student(15128,"Adam", "Adamy","AdamTheStudent","adam123456",Major.Communications,new List<int>(){8,9,10}),
              new Student(15129,"Jeny", "Jensky","JenyTheStudent","jeny123456",Major.Communications,new List<int>(){6,10,6}),
              new Student(15130,"Helen", "Helensky","HelenTheStudent","helen123456",Major.Communications,new List<int>(){10,9,8}),
              new Student(15131,"Jony", "Bonbony", "JonyTheStudent","jony123456",Major.CS,new List<int>(){6,7,8}) ,
              new Student(15132,"Woody", "Woodsy", "WoodyTheStudent","woody123456",Major.CS,new List<int>(){10,10,9}),
              new Student(15133,"Maddie", "Maddsie", "MaddieTheStudent","maddie123456",Major.CS,new List<int>(){9,7,9}),
              new Student(15134,"Stella", "Strella", "StellaTheStudent","stella123456",Major.Architecture,new List<int>(){10,9,10}),
              new Student(15135,"Bardy", "Bardsky", "BardyTheStudent","bardy123456",Major.Architecture,new List<int>(){6,9,8}),
              new Student(15136,"Melly", "Mellsky", "MellyTheStudent","melly123456",Major.Architecture,new List<int>(){7,8,10}),   
        };

        public static List<Teacher> teachers = new List<Teacher>()
        {
             new Teacher(1,"John", "Johnsky","TrainerJohn","trainerJohn12345")
        };
    }
}
