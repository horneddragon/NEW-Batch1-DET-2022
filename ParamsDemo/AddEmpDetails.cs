using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class AddEmpDetails
    {
        public static void Main()
        {

            empdetails getDetails = new empdetails(1, "Ani", "GV", 560001, 8310241367, 30000);
            CalGradeSal getGrade = new CalGradeSal();
            Console.WriteLine($"Net Salary is {getDetails.GetNetSalary()}");
            Console.WriteLine($"Grade is {getGrade.calEmpGrade()}");
        }
    }
}
