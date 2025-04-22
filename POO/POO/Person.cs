using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Person
    {

        // -> Attributes
        // Properties and different access modifiers
        public int age;                 // Public access modifier, it can be accessed from anywhere
        private string name;            // Private access modifier, it can only be accessed within the class
        protected string address;       // Protected access modifier, it can be accessed within the class and by derived classes
        internal string phoneNumber;    // Internal access modifier, it can be accessed within the same assembly

        // -> Methods
        // Constructor without parameters
        public Person()
        {

        }

        // Constructor with parameters
        public Person(string name, int age, string address, string phoneNumber)
        {
            this.name = name;
            this.age = age;
            this.address = address;
            this.phoneNumber = phoneNumber;
        }

        // In the case of private atributes, we can use properties to access them
        public string Name {
            get { return name; } // Getter method to access the private attribute
            set { name = value; } // Setter method to modify the private attribute
        }

        public void presentation()
        {
            Console.WriteLine("Hello, my name is " + name + ", I am " + age + " years old, I live in " + address + " and my phone number is " + phoneNumber);
        }
    }
}
