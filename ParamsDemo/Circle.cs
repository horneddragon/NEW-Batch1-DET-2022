using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        double Radius;


        public Circle(double radius)
        {
            Radius = radius;
        }

        public double FindArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
