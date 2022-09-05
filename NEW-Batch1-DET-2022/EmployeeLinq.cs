//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NEW_Batch1_DET_2022
//{
//    public class EmployeeLinq
//    {
      

//        public EmployeeLinq(int id, string name, string dept)
//        {
//            ID = id;
//            Name = name;
//            Dept = dept;

//        }
//        public int ID { get; set; }
//        public string Name { get; set; }
//        public string Dept { get; set; }

//        List<EmployeeLinq> GetListofEmployees()
//        {
//            List<EmployeeLinq> emps = new List<EmployeeLinq>();
//            emps.Add(new EmployeeLinq(1, "John", "Training"));
//            emps.Add(new EmployeeLinq(2, "Mark", "Finance"));
//            emps.Add(new EmployeeLinq(3, "Peter", "Technical"));
//            emps.Add(new EmployeeLinq(4, "Bob", "Technical"));
//            emps.Add(new EmployeeLinq(5, "Robert", "Finance"));
//            emps.Add(new EmployeeLinq(6, "Jason", "Training"));

//            return emps;
//        }

//        public static void SampleEmployeeList()
//        {
//            List<EmployeeLinq> emps = new List<EmployeeLinq>();

//            var emp_query = from employee in emps
//                            select employee;

//            foreach (var item in emp_query)
//            {
//                Console.WriteLine("Name is " + item.Name + "and dept is " + item.Dept);
//            }
//            Console.ReadLine();
//        }


//        public static void Main()
//        {
            

//            Console.WriteLine(GetListofEmployees());
//        }
//    }
//}
