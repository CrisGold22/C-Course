using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public  class Animal
    {
        private string name;
        private string gender;

        public Animal()
        {

        }

        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }

        public void greating()
        {
            Console.WriteLine("Hello, my name is {0} and I'm {1}", this.name, this.gender);
        }
    }
}
