using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hamster : Pet
    {
        public Hamster(int index, string name, string breed, int age, Gender gender, PetType type) : base(index, name, breed, age, gender, type)
        {
        }
        public override string GetInfo()
        {
            return $"Name: {Name} Breed: {Breed} Pet: {Type} Age: {Age} Months Gender: {Gender}";
        }
    }
}
