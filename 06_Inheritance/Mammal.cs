using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Inheritance
{
    public class Mammal : Animal
    {
        public string FurColor { get; set; }
        public Mammal()
        {
            HasFur = true;
            NumberOfLegs = 4;
            Console.WriteLine("This is the Mammal constructor");
        }
        public override void MakeSound()
        {
            Console.WriteLine("ROAR!");
        }

    }

    public class Dog : Mammal
    {
        public bool HasFloppyEars { get; set; }
        public Dog()
        {
            
        }
    }

    public class Reptile : Animal
    {
        public Reptile()
        {
            
        }
    }
}
