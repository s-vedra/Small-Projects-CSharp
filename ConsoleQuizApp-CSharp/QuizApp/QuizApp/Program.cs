using Services;



while (true)
{
    try
    {
        Console.Clear();
        Console.WriteLine("Hello user! Choose your role \n1.Teacher \n2.Student \n3.Exit", Console.ForegroundColor = ConsoleColor.White);
        int choice = HelperMethods.Parsing(Console.ReadLine());
        if (choice == 1)
        {
            TeacherService.TeacherLogin();
            continue;
        }
        else if (choice == 2)
        {
            StudentService.StudentLogin();
            continue;
        }
        else if (choice == 3)
        {
            Console.WriteLine("Goodbye");
            break;
        }
        else
        {
            throw new Exception("Please choose 1, 2 or 3, press enter to continue");
        }
    }
    catch (Exception msg)
    {
        Console.WriteLine(msg.Message);
        Console.ReadLine();
        continue;
    }
}


