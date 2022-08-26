using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class Emp
    {
        int EmpID;
        string Name;
        string Dept;
        double Sal;
        DateOnly DOJ;
        private int v1;
        private string v2;
        private int v3;

        public Emp(int empid, string name, DateOnly doj)
    {
             EmpID = empid; Name = name; DOJ = doj;
    }

       
        public int GetYearsOfExp()
        {
            return DateTime.Now.Year - DOJ.Year;
        }



    }
}
