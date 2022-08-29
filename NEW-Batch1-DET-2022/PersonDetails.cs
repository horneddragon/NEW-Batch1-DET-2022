//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_3
//{
//    internal class Person
//    {
//        //public string name { get; set; }
//        //public DateTime DOB { get; set; }
//        //public String add { get; set; }
//        //public MarStat marstat { get {return marstat ;} set { marstat = value;  } }
//        string name;
//        DateTime DOB;
//        String Add;


//        Person(string name, DateTime DOB, String add/*, string Marstat*/)
//        {
//            this.name = name;
//            this.DOB = DOB;
//            this.Add = add;

//        }

//        public int GetAge()
//        {
//            return DateTime.Now.Year - this.DOB.Year;
//        }
//        bool CanMarry()
//        {

//            if (GetAge() >= 18)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static void Main()
//        {

//            Person person = new Person("Anirudha", new DateTime(2001 / 03 / 12), "GV");

//        }
//        //static String GetMarStat(MarStat marstat)
//        //{
//        //    switch (marstat)
//        //    {
//        //        case MarStat.Single:
//        //            return "Single";
//        //        case MarStat.Married:
//        //            return "Married";
//        //        case MarStat.Divorced:
//        //            return "Divorced";
//        //        case MarStat.Widowed:
//        //            return "Widowed";

//        //    }
//        //}


//    }


//}