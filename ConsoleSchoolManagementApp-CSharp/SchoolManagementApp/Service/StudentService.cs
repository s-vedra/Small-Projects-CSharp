using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public  class StudentService
    {
        public static void StudentLogin()
        {
            Student student = UserService<Student>.Login(UsersDB.students);
            Console.Clear();
            while (true)
            {
                try
                {
                    if (student != null)
                    {
                        Console.WriteLine($"Please choose \n1.See grades \n2.Calculate average grade \n3.Exit");
                        int studentAnswer = HelperMethods.Parsing(Console.ReadLine());
                        if (studentAnswer == 1)
                        {
                            Console.Clear();
                            student.PrintGrades();
                        }
                        else if (studentAnswer == 2)
                        {
                            Console.Clear();
                            Console.WriteLine($"Average grade: {Math.Floor(student.GetAverageGrade() * 10) / 10}");
                        }
                        else if (studentAnswer == 3)
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye");
                            break;
                        }
                        else
                        {
                            throw new Exception("Please choose 1, 2 or 3");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("No student found");
                    }
                }
                catch (NullReferenceException msg)
                {
                    Console.Clear();
                    Console.WriteLine(msg.Message);
                    break;
                }
                catch (Exception msg)
                {
                    Console.Clear();
                    Console.WriteLine(msg.Message);
                    continue;
                }

            }
        }
    }
}
