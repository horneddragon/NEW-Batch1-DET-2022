using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    internal class TestCircle
    {
        const double V = 5;

        public static void Main()
        {
            Circle circle = new Circle(V);
            Console.WriteLine($"Area of circle is {circle.FindArea()}");
        }
    }
}
