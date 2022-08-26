using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsDemo
{
    internal class empdetails
    {
        int EmpRoll;
        string EmpName;
        string Add;
        int Pincode;
        long phone;
        double GSal;
        //int pf;


        public empdetails(int EmpRoll,string EmpName,string Add,int Pincode,long phone,double GSal)
        {
            this.EmpRoll = EmpRoll;
            this.EmpName = EmpName;
            this.Add = Add; 
            this.Pincode = Pincode;
            this.phone = phone;
            this.GSal = GSal;   
            //this.pf = pf;  
            
        }

        public double GetNetSalary()
        {
            double pf = 12 * this.GSal / 100; 
            double netSalary = 0;
            return netSalary = this.GSal - pf ;
        }
    }
}
