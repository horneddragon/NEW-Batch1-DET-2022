using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class AddEmpDetails
    {
        public static void Main()
        {

            EmpDetails getDetails = new EmpDetails(1, "Ani", "GV", 560001, 8310241367, 30000);
            Salary getGrade = new Salary();
            Console.WriteLine($"Net Salary is {getDetails.GetNetSalary()}");
            Console.WriteLine($"Grade is {getGrade.GetGrade()}");
        }
    }
}
