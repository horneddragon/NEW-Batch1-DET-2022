using Assignment_3;
using BATCH1_DET_2022;
using ConsoleAppDemo;

//See https://aka.ms/new-console-template for more information
using ConsoleAppDemo;
using NEW_Batch1_DET_2022;
using System.Net;
using System.Xml.Linq;

class MyClass
{
    //enum Grade { Pass = 60, Distinction = 85 };
    /// <summary>
    /// method that returns Grade based on the mark
    /// </summary>
    /// <param name="mark">mark as the input</param>
    /// <returns></returns>
    //public static string GetGrade(int mark) //IN parameter
    //{
    //    if (mark >= (int)Grade.Distinction)
    //        return "Distinction";
    //    else if (mark >= (int)Grade.Pass)
    //        return "PASS";
    //    else
    //        return "FAIL";
    //}

    //public static void Main()
    //{
    //    Manager m = new Manager(4671,"Karthika",new DateOnly(2005,5,10),"techtrng",10);  //default constructor
    //    Console.WriteLine(m.Print());

    //    Manager m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
    //    Console.WriteLine(m1.Print());

    //    Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
    //    Console.WriteLine(e1.Print());

    //}
    //public static void Main()
    //{
    //    Emp m = new Manager(4671, "Karthika", new DateOnly(2005, 5, 10), "techtrng", 10);  //default constructor
    //                                                                                       // Console.WriteLine(m.Print());

    //    Emp m1 = new Manager(2345, "Jeeva", new DateOnly(2010, 1, 14), "PEMS", 450);
    //    // Console.WriteLine(m1.Print());  //base class ref can point to derived object

    //    Emp e1 = new Emp(1, "Jiyana", new DateOnly(2020, 1, 5));
    //    //Console.WriteLine(e1.Print());

    //    List<Emp> list = new List<Emp>();
    //    list.Add(m);
    //    list.Add(m1);
    //    list.Add(e1);
    //    foreach (Emp x in list)
    //        Console.WriteLine(x.Print());

    //}


    //    public static void Main()
    //    {
    //        CompanyManager m = new CompanyManager { Name = "Balaji", Surname = "R", Phonenumber = "8310241367"};
    //        Company company = new Company { Name = "Ani", Address = "address", Phonenumber = "phonenumber", Manager = m ,Website = "sonata-software.com"};

    //        Console.WriteLine(company.Print());
    //    }

    //}

    //public class Shape
    //{
    //    public static void Main()
    //    {
    //        Circle c = new Circle { Radius = 4 };
    //        Sphere s = new Sphere { Radius = 4 };
    //        Console.WriteLine($"Area of circle is {c.Area()}, Area of Sphere is {s.Area()} ");
    //    }
    //}


    public class AnimalClass
    {
        public static void Main()
        {

            List<Animal> list = new List<Animal>();
            list.Add(new Dog { Age = 4, Name = "Shino", Gender = "Male" });
            list.Add(new Cat { Age = 9, Name = "Kiro", Gender = "Female" });
            list.Add(new Frog { Age = 8, Name = "Mandy", Gender = "Male" });
            list.Add(new Kitten { Age = 4, Name = "Kitty", Gender = "Male" });
            list.Add(new TomCat { Age = 7, Name = "Madara", Gender = "Male" });

            foreach (var item in list)
            {
                Console.WriteLine($"{item.MakeSound()}");
            }

        }

    }
}


public class Classmain1
{
    public static Student Student { get; private set; }

    public static void Main()
    {
        ScienceStudent Student = new ScienceStudent { regno =22813, Name = "Anirudha" };
        ScienceStudent sciencesubject = new ScienceStudent { physics = 90, chemistry = 95, maths = 75 };
        CommerceStudent Commercessubject = new CommerceStudent { economices = 98, accounts = 66, banking = 59 };

        Console.WriteLine($"Science Average is {sciencesubject.GetAvgMarks()}");
        Console.WriteLine($"Commerce Average is {Commercessubject.GetAvgMarks()}");
    }
}

public class PersonMain
{
    public static void Main()
    {
        try
        {
            RefTypPerson t = new RefTypPerson("Anirudha", "puranic", "abc@xxx.com", new DateTime(2001, 03, 12));
            int byear = t.BirthYear();
            if (byear < 1900 || byear > 2022)
            {
                throw new InvalidBirthYearException("ENTER VALID BIRTH YEAR");
            }
            string r = t.GetSunSign();
            string s = t.ChineseZodiac();
            string w = t.IsAdult();
            string b = t.BDayStatus();
            string u = t.DefaultUsername();
            string n = t.GetInfo();
            Console.WriteLine($"NAME = {n}");
            Console.WriteLine($"Sun Sign = {r}");
            Console.WriteLine($"Chinese Zodiac = {s}");
            Console.WriteLine($"Age Status = {w}");
            Console.WriteLine($"Birthday Status = {b}");
            Console.WriteLine($"Default Username = {u}");
        }
        catch (InvalidBirthYearException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (Exception m)
        {
            Console.WriteLine(m.Message);
        }
    }
}
