using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    internal class RadandDia
    {
        double radius;
        double diameter;

        public double Radius { get; set; }
        public double Diameter { get; set; }

        //public double Circumference { get; set; }

        double CalArea()
        {
            return Math.PI * Radius * Radius;
        }

        double CalDia()
        {
            return Radius * 2;
        }

        //double CalCircum()
        //{
        //    return 2 * Math.PI * Radius;
        //}

        public static void Main()
        {
            RadandDia radanddia = new RadandDia { Radius = 25, Diameter = 50 };
            double radius = radanddia.CalArea();
            Console.WriteLine($"Radius of the circle is{radius}");
            double diameter = radanddia.CalDia();
            Console.WriteLine($"Diameter of the circle is {diameter}");
            //double circum = radanddia.CalCircum();
            //Console.WriteLine(circum);
        }







    }


}
