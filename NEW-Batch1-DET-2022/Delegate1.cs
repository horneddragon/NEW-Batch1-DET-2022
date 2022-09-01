using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class Delegate1
    {
    public static void Main()
        {
            //Action type
            Action<string> action = (string name) => { Console.WriteLine($"Hi {name}"); };
            action.Invoke("Ani");
            Action<string, string> action1 = (string name, string place) => { Console.WriteLine($"Hi {name}, from {place}"); };
            action1.Invoke("Ani", "BGM");

            Action<string, int, string> action3 = (string name, int id, string mail) => { Console.WriteLine($"{name},{id},{mail}"); };
            action3("Ani",123,"@.com");
            // passing action to action4
            Action<string> action4 = (action) => { Console.WriteLine($"hi there {action}"); };
           
            action4.Invoke("Anirudha");

            //Func type
            Func<int,int,long> multiply = (x, y) => { return x * y; };

            long result = multiply(10, 100);
            Console.WriteLine(result);

        
        
        
        
        
        }

    }
}
