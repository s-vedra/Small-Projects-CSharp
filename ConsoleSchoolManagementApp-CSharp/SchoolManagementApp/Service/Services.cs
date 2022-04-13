using Service;

namespace Models
{
    public static class Services<T>  where T : User
    {
        
        public static T Login(List<T> users) 
        {
            int attempt = 3;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter username");
                    string username = Console.ReadLine();
                    foreach (T user in users)
                    {
                        if (user.Username == username && !string.IsNullOrEmpty(username))
                        {
                            Console.WriteLine("Enter password");
                            string password = Console.ReadLine();
                            if (user.Password == password && !string.IsNullOrEmpty(password))
                            {
                                return user;
                            }
                            else if (attempt == 0)
                            {
                                throw new ArgumentException("Too many attempts");
                            }
                        }
                        else if (attempt == 0)
                        {
                            throw new ArgumentException("Too many attempts");
                        }
                    }
                    attempt--;
                    throw new Exception("Username or password is incorrect");
                }
                catch (ArgumentException msg)
                {
                    Console.WriteLine(msg.Message);
                    return null;
                }
                catch (Exception msg)
                {
                    Console.WriteLine(msg.Message);
                    continue;
                }
            }
        }

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
        public static void StudentLogin()
        {
            Student student = Services<Student>.Login(UsersDB.students);
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
