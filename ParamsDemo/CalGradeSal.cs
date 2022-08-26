using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class CalGradeSal
    {

        public string calEmpGrade()
        {

            empdetails getgrade = new empdetails(1, "Ani", "GV", 560001, 8310241367, 30000);
            if (getgrade.GetNetSalary() > 10000)
            {
                return "Grade - A";
            }
            else if (getgrade.GetNetSalary() > 5000)
            {
                return "Grade - B";
            }
            else
            {
                return "Grade - c";
            }
        }
    }
}
