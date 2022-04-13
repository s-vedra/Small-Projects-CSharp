using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TeacherService
    {
        public static void TeacherLogin()
        {
            Teacher teacher = Services<Teacher>.Login(UsersDB.teachers);
            Console.Clear();
            while (true)
            {
                try
                {
                    if (teacher != null)
                    {
                        Console.WriteLine($"Please choose \n1.See all students \n2.Search for a student " +
                            $"\n3.See students with best average grade " +
                            $"\n4.See max average per major \n5.Exit");
                        int teacherAnswer = HelperMethods.Parsing(Console.ReadLine());
                        if (teacherAnswer == 1)
                        {

                            teacher.SortStudents();
                        }
                        else if (teacherAnswer == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Enter index number:");
                            string index = Console.ReadLine();
                            Student student = teacher.SearchStudent(HelperMethods.Parsing(index));
                            if (student != null)
                            {
                                Console.Clear();
                                student.PrintInfo();
                            }
                            else
                            {
                                throw new NullReferenceException("No student found");
                            }
                        }
                        else if (teacherAnswer == 3)
                        {
                            Console.Clear();
                            teacher.BestAverageStudents();
                        }
                        else if (teacherAnswer == 4)
                        {
                            Console.Clear();
                            Console.WriteLine("1.CS \n2.Communications \n3.Architecture \n4.Bussines \n5.Arts");
                            int answerMajor = HelperMethods.Parsing(Console.ReadLine());
                            if (answerMajor > 5)
                            {
                                throw new ArgumentNullException("Invalid input, please choose 1-5");
                            }
                            else
                            {
                                Major major = (Major)answerMajor;
                                float maxAverage = teacher.ReturnMaxAverageMajor(major);
                                if (maxAverage == 0)
                                {
                                    Console.WriteLine("There are no students in this major");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine($"{major} {maxAverage}");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (teacherAnswer == 5)
                        {
                            Console.Clear();
                            Console.WriteLine("Goodbye");
                            break;
                        }
                        else
                        {
                            Console.Clear();
                            throw new ArgumentException("Please choose 1-5");
                        }
                    }
                    else
                    {
                        throw new NullReferenceException("No user found");
                    }
                }
                catch (NullReferenceException msg)
                {
                    Console.WriteLine(msg.Message);
                    break;
                }
                catch (ArgumentException msg)
                {
                    Console.WriteLine(msg.Message);
                    continue;
                }

            }
        }
    }
}
