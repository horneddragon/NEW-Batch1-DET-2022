using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class LinqExercise
    {
        public static void Main()
        {
            string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

            var nam = from n in names
                       where n.Contains('o')
                       select n;

            foreach (string n in nam)
                Console.WriteLine(n);



            string[] names3 = { "John", "Peter", "Jacob", "Harry", "Jackson" };
            var names2 = names.OrderByDescending(x => x.Length);
            var result = names2.Take(1);
            foreach (var name in result)
                Console.WriteLine(name);











            string[] words1 = { "believe", "relief", "receipt", "field" };

            foreach (string word in words1)
            {
                Console.WriteLine($"{word}--{word.Length} ");
            }


            string[] words = { "blueberry", "blackberry", "abacus" };
            foreach (string item in words)
                Console.WriteLine( item.Reverse().ToArray());




        }

        }





    }

    




























        //public static void Main()
        //{
        //    string[] names = { "John", "Peter", "Jacob", "Harry", "Jackson" };

        //    var name = from n in names
        //               where n.Contains('o')
        //               select n;

        //    foreach (string n in name)
        //        Console.WriteLine(n);



        //}

    