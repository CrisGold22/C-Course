using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Circle : Figure
    {
        private double radius;

        public Circle(string color, double radio) : base(color)
        {
            this.radius = radio;
        }

        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI ;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}
