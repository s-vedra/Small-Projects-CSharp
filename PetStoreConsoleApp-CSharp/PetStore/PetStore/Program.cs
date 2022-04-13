using Models;
using Service;

Console.WriteLine("Hello user, what do you want to do?");
while (true)
{
    try
    {
        Console.WriteLine("1.Buy a pet \n2.See all pets \n3.Exit");
        int choice = HelperMethods.Parsing(Console.ReadLine());

        if (choice == 1)
        {
            Services<Pet>.ChoosePet();
        }
        else if (choice == 2)
        {
            Console.Clear();
            Console.WriteLine("Dogs:");
            Services<Dog>.PrintPets(PetDB.dogs);
            Console.WriteLine("====================================================");
            Console.WriteLine("Cats:");
            Services<Cat>.PrintPets(PetDB.cats);
            Console.WriteLine("====================================================");
            Console.WriteLine("Hamsters:");
            Services<Hamster>.PrintPets(PetDB.hamsters);
            Console.WriteLine("====================================================");
            Console.WriteLine("Do you want to buy a pet? Y/N");
            string answer = Console.ReadLine().ToLower();
            if (answer == "y")
            {
                Console.Clear();
                Services<Pet>.ChoosePet();
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                throw new Exception("Invalid input, please choose the correct answer");
            }
        }
    }
    catch (Exception msg)
    {
        Console.Clear();
        Console.WriteLine(msg.Message);
    }
    break;
}



