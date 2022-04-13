using Enums;

namespace Models
{
    public abstract class Pet
    {
        public int Index { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public PetType Type { get; set; }

        public Pet(int index, string name, string breed, int age, Gender gender, PetType type)
        {
            Index = index;
            Name = name;
            Breed = breed;
            Age = age;
            Gender = gender;
            Type = type;
        }
        public virtual string GetInfo()
        {
            return $"Name: {Name} Breed: {Breed} Pet: {Type} Age: {Age} Years Gender: {Gender}";
        }
    }
}