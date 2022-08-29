using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    public class Company
    {
        public string Name { get; internal set; }
        public string Address { get; internal set; }
        public string Phonenumber { get; internal set; }
        public CompanyManager Manager { get; internal set; }
        public string Website { get; internal set; }
        string name { get; set; }
        string address { get; set; }
        string phonenumber { get; set; }
        string website {get; set;}
        CompanyManager manager { get; set; }
       override public string ToString()
        {
            return $"{name},{address},{phonenumber},{manager},{website}";
        }
    }
    

    
}

