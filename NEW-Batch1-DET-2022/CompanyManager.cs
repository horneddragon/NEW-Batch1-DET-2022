using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    public class CompanyManager
    {
        public string Surname { get; internal set; }
        public string Name { get; internal set; }
        public string Phonenumber { get; internal set; }
        string name { get; set; }
        string surname { get; set; }
        string phonenumber { get; set; }    

       override public string ToString()        
        {
            return $"{name},{surname},{phonenumber}";
        }

    }
}
