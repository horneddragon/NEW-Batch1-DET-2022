//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignment_3
//{
//    internal class RefTypPerson
//    {
//        String FirstName;
//        String LastName;
//        String Email;
//        DateTime DOB;
//         public RefTypPerson(string firstName, string lastName, string email, DateTime dOB)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Email = email;
//            DOB = dOB;
//        }
//        RefTypPerson(string first, string last, string email)
//        {
//            FirstName = first;
//            LastName = last;
//            Email = email;


//        }
//        RefTypPerson(string first, string last, DateTime dob)
//        {
//            FirstName = first;
//            LastName = last;
//            DOB = dob;
//        }
//        public int GetAge(int age)
//        {
//            return DateTime.Now.Year - DOB.Year;
//        }

//        public readonly string Adult;
//        public readonly string SunSign;
//        public readonly string ChineseSign;
//        public readonly int Birthday;
//        public readonly string ScreenName;

//        readonly struct Properties
//        {
//            public readonly string Adult 
//            {get
//                {
//                    if ( GetAge() > 18)
//                    {
//                        return "IS Adult";
//                    }
//                    return true;
//                }
//            }
//            public readonly string SunSign { get { return "Libra"; } }
//            public readonly string ChineseSign { get { return "Snake"; } }
//            public readonly string Birthday { get { return "True "; } }
//            public readonly string ScreenName { get { return "HornedDragon"; } }

//        }


//        public static void Main()
//        {
//            RefTypPerson reftypperson = new RefTypPerson("Anirudha", "Puranic", "anirudh.pv@sonata-software.com");

//            Properties properties = new Properties(/*"Adult","Libra","Snake", 21, "Horneddragon"*/);
//            Console.WriteLine($"{properties.Adult}");
//            Console.WriteLine($"{properties.SunSign}");
//            Console.WriteLine($"{properties.ChineseSign}");
//            Console.WriteLine($"{properties.Birthday}");
//            Console.WriteLine($"{properties.ScreenName}");

//        }
//    }
//}