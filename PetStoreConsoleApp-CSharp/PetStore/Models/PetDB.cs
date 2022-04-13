using Enums;

namespace Models
{
    public static class PetDB
    {
        public static List<Cat> cats = new List<Cat>()
        {
            new Cat(1, "Tom","Tuxedo", 10, Gender.Male,PetType.Cat),
            new Cat(2, "Whiskers","Siamese", 2, Gender.Female,PetType.Cat),
            new Cat(3, "Bella","Persian", 5, Gender.Female, PetType.Cat),
            new Cat(4, "Loki","Scottish Fold", 2, Gender.Male, PetType.Cat)
        };
        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog(1, "Bruno", "Beagle", 4, Gender.Male, PetType.Dog),
            new Dog(2, "Nala", "Labrador", 1, Gender.Female, PetType.Dog),
            new Dog(3, "Max", "Pug", 3, Gender.Male, PetType.Dog),
            new Dog(4, "Lucy", "Poodle", 1, Gender.Female, PetType.Dog)
        };
        public static List<Hamster> hamsters = new List<Hamster>()
        {
            new Hamster(1, "Cheeks", "Golden Hamster", 5, Gender.Female, PetType.Hamster),
            new Hamster(2, "Chewy", "Teddy Bear Hamster", 3, Gender.Male, PetType.Hamster),
            new Hamster(3, "Fuzzy", "Black Bear Hamster", 2, Gender.Female, PetType.Hamster),
            new Hamster(4, "Harry", "Panda Bear Hamster", 6, Gender.Male, PetType.Hamster),
        };
        public static List<Fish> fish = new List<Fish>();
    }
}
