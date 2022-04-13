using Models;
namespace Service
{
    public static class Services<T> where T : Pet
    {
        public static void PrintPets(List<T> pets)
        {

            foreach (T pet in pets)
            {
                Console.WriteLine(pet.GetInfo());
            }

        }

        public static List<T> Remove(T pet, List<T> pets)
        {
            pets.Remove(pet);
            return pets;
        }
        public static T BuyPet(List<T> pets)
        {

            try
            {
                PrintPets(pets);
                if (pets.Count != 0)
                {
                    Console.WriteLine("Type the name of the pet you want to buy");
                    string answer = Console.ReadLine();
                    foreach (T p in pets)
                    {
                        if (p.Name.ToLower() == answer.ToLower())
                        {
                            Remove(p, pets);
                            return p;
                        }
                    }
                    throw new Exception("No pet was found");
                }
                else
                {
                    throw new NullReferenceException("Sorry, currently there are no pets of that type");
                }
            }
            catch (NullReferenceException msg)
            {
                Console.WriteLine(msg.Message);
                return null;
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg.Message);
                return null;

            }

        }

        public static bool PetBought(T pet)
        {
            if (pet != null)
            {
                Console.WriteLine($"You just bought: \n({pet.GetInfo()})");
                return false;
            }
            else
            {
                Console.WriteLine("Press enter if you want to choose a different pet, if not press X");
                if (Console.ReadLine().ToLower() == "x")
                {
                    Console.WriteLine("Goodbye");
                    return false;
                }
                Console.Clear();
            }
            return true;
        }

        public static void ChoosePet()
        {
            while (true)
            {
                Console.WriteLine("Choose an option \n1.Dogs \n2.Cats \n3.Hamsters \n4.Fish");
                int answer = HelperMethods.Parsing(Console.ReadLine());
                if (answer == 1)
                {
                    Dog dog = Services<Dog>.BuyPet(PetDB.dogs);
                    if (Services<Dog>.PetBought(dog) == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (answer == 2)
                {
                    Cat cat = Services<Cat>.BuyPet(PetDB.cats);
                    if (Services<Cat>.PetBought(cat) == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }

                }
                else if (answer == 3)
                {
                    Hamster hamster = Services<Hamster>.BuyPet(PetDB.hamsters);
                    if (Services<Hamster>.PetBought(hamster) == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (answer == 4)
                {
                    Fish fish = Services<Fish>.BuyPet(PetDB.fish);
                    if (Services<Fish>.PetBought(fish) == false)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                break;
            }
        }
    }
}