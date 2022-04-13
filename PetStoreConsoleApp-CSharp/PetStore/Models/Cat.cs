using Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cat : Pet
    {
        public Cat(int index, string name, string breed, int age, Gender gender, PetType type) : base(index,name, breed, age, gender, type)
        {
        }
    }
}
