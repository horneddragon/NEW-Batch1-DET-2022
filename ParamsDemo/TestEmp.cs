using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class TestEmp
    {
        public static void Main()
        {
            Emp emp = new Emp(22813, "Anirudha", new DateOnly(2020, 8, 1));
            Console.WriteLine($"Experience is {emp.GetYearsOfExp()} years");
        }
    }
}
