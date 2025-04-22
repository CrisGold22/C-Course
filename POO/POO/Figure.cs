using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public abstract class Figure
    {
        private string color;

        public Figure(string color)
        {
            this.color = color;
        }

        public string Color {
            get { return color; }
            set { color = value; }
        }

        // It isn't abstract or virtual methods, it means that this method can not be overridden in derived classes
        public void greating()
        {
            Console.WriteLine("Hello, I am a figure.");
        }

        //virtual method to be overridden in derived classes. This method must be declareded in base class  
        public virtual void printingColor()
        {
            Console.WriteLine("The color of the figure is: " + color);
        }

        public abstract double Area(); // Abstract method to calculate the area of the figure
        public abstract double Perimeter(); // Abstract method to calculate the perimeter of the figure
        //-> This method must be implemented in derived classes
    }
}
