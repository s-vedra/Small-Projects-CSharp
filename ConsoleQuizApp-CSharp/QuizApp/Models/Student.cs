using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Models
{
    public class Student : User, IStudent
    {
        public int Grade { get; set; }
        public bool FinishedQuiz { get; set; }
        public int Points { get; set; }

        public Student(string name, string lastname, string password, string username)
            : base(name, lastname, Role.Student, password, username)
        {
        }

        public int ReturnPoints()
        {
            foreach (Questions question in QuestionsDB.questions)
            {
                Console.WriteLine(question.Question);
                question.Options.ForEach(option => Console.WriteLine(option));
                while (true)
                {
                    if (!int.TryParse(Console.ReadLine(), out int answer))
                    {
                        Console.WriteLine("Invalid input");
                        continue;
                    }
                    if (answer == question.Answers)
                    {
                        Points += 5;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect answer");
                    }
                    break;
                }

            }
            Grade = ReturnGrade(Points);
            FinishedQuiz = true;
            return Points;
        }

        public int ReturnGrade(int points)
        {
            Console.WriteLine("Max points: 25");
            if (points >= 20 && points <= 25)
            {
                return 5;

            }
            else if (points >= 14 && points <= 19)
            {
                return 4;
            }
            else if (points >= 8 && points <= 13)
            {
                return 3;
            }
            else if (points >= 2 && points <= 7)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public override string ReturnInfo()
        {
            if (Grade == 0)
            {
                return $"{base.ReturnInfo()} Points: {Points} Grade: Has not taken the quiz yet";
            }
            return $"{base.ReturnInfo()} Points: {Points} Grade: {Grade}";
        }
    }
}
