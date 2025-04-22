using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Dog : Animal  // Dog is a child class of Animal
    {
        private int age;
        private string race;

        public Dog()
        {

        }

        public int Age { get { return age; } set { age = value; } }
        public string Race { get { return race; } set { race = value; } }

        public void bark()
        {
            Console.WriteLine("Woof! Woof!");
        }
    }
}
