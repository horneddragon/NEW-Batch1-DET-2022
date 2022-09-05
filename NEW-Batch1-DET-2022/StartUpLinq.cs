//using System;
//using System.Collections.Generic;
//using System.Diagnostics;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace NEW_Batch1_DET_2022
//{
//    public static class StartUpLinq
//    {
//        public static void func()
//        {
//            1.Create DataSource
//                        //List<int> numbers = new List<int>() { 100, 101, 102, 103, 104 };


//            //2. Create Query
//            //2.1 Deffered execution
//            //var NumQuery = from num in numbers
//            //               where num >= 103
//            //               select num;

//            //numbers.Add(200);
//            //2.2

//            //3. Execute Query
//            //var NumQuery = (from num in numbers
//            //                select num).ToList();

//            //numbers.Add(200);
//            //2.3 Lambda Expression

//            //var numQuery = numbers.Select(x => x);

//            //int[] numbers = { 1, 2, 3, 4, 5 };

//            ////var result = numbers.OrderBy(x => x).ToList();

//            //var result = numbers.OrderByDescending(x => x).ToList();

//            //foreach (int num in result)
//            //{
//            //    Console.WriteLine("{0}", num);
//            //}




//            //List<String> cities = new List<string>() { "Berlin", "Paris", "Madrid", "Tokyo", "London",
//            //              "Athens", "Beijing", "Seoul"};

//            //var city = cities.OrderBy(x => x.Length);

//            //foreach (string c in city)
//            //{
//            //    Console.WriteLine("{0}", c);
//            //}

//            //    var dates = new DateTime[] {
//            //new DateTime(2015, 3, 1),
//            //new DateTime(2014, 7, 1),
//            //new DateTime(2013, 5, 1),
//            //new DateTime(2015, 1, 1),
//            //new DateTime(2015, 7, 1) };


//            //    var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

//            //    Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
//            //    foreach (DateTime dt in result)
//            //    Console.WriteLine(dt.ToString("yyyy/MM/dd"));



//            //string[] numbers = { "one", "six", "three", "four", "five", "two" };
//            //var results = numbers.Skip(3);                 
//            //foreach (var number in results)
//            //    Console.WriteLine(number);

//            //string[] numbers = { "one", "six", "three", "four", "five" };
//            //var results = numbers.SkipWhile(x => x.Length == 3);      ///
//            //foreach (var number in results)
//            //    Console.WriteLine(number);

//            //string[] numbers = { "one", "six", "three", "four", "five", "two" };
//            //var results = numbers.SkipWhile(x => x.Length == 3);      ///
//            //foreach (var number in results)
//            //    Console.WriteLine(number);

//            //int[] numbers = { 1, 2, 3, 4, 6, 6, 7, 8, 9, 10 };
//            //var results = numbers.Take(5);
//            //foreach (var number in results)
//            //    Console.WriteLine(number);

//            //int[] numbers = { 1, 2, 3, 4, 6, 6, 7 };
//            //var results = numbers.TakeWhile(x => x < 6);             /////
//            //foreach (var number in results)
//            //    Console.WriteLine(number);


//            /*int[] agg = { 1, 2, 3, 4, 5 };
//           var res = agg.Aggregate((a,b) => a + b);
//            Console.WriteLine(res);*/


//            //int[] avgg = { 1, 3, 5, 7, 8, 9 };
//            //double res = avgg.Average();
//            //return res;

//            //int[] numbers = { 10, 10, 11, 11 };

//            //   double result = numbers.Average();

//            //   Console.WriteLine("Average is:");
//            //   Console.WriteLine(result);



//            //string[] names = { "Peter", "John", "Kathlyn", "Allen", "Tim" };

//            //var result = names.Count();

//            //Console.WriteLine("Counting names gives:");
//            //Console.WriteLine(result);



//            //int[] numbers = { 2, 5, 6, 1,8 };

//            //var result = numbers.Max();

//            //Console.WriteLine("Highest number is:");
//            //Console.WriteLine(result);

//            //int[] numbers = { 6, 9, 3, 7, 5 };

//            //var result = numbers.Min();

//            //Console.WriteLine("Lowest number is:");
//            //Console.WriteLine(result);

//            //int[] numbers = { 2, 5, 10 };

//            //var result = numbers.Sum();

//            //Console.WriteLine("Summing the numbers yields:");
//            //Console.WriteLine(result);


//            //string[] words = { "One", "Two", "Three" };

//            //var result = words.ElementAt(1);

//            //Console.WriteLine("Element at index 1 in the array is:");
//            //Console.WriteLine(result);



//            //string[] colors = { "Red", "Green", "Blue" };

//            //var resultIndex1 = colors.ElementAtOrDefault(1);

//            //var resultIndex10 = colors.ElementAtOrDefault(10);

//            //Console.WriteLine(resultIndex1);

//            //Console.WriteLine(resultIndex10 == null);

//            //string[] fruits = { "Banana", "Apple", "Orange" };

//            //var result = fruits.First();

//            //Console.WriteLine("First element in the array is:");
//            //Console.WriteLine(result);

//            //string[] countries = { "Denmark", "Sweden", "Norway" };

//            //var result = countries.First(c => c.Length == 6);

//            //Console.WriteLine("First element with a length of 6 characters:");
//            //Console.WriteLine(result);


//            //string[] countries = { "Denmark", "Sweden", "Norway" };
//            //string[] empty = { };

//            //var result = countries.FirstOrDefault();

//            //var resultEmpty = empty.FirstOrDefault();

//            //Console.WriteLine(result);

//            //Console.WriteLine(resultEmpty == null);

//            //int[] numbers = { 7, 3, 5 };

//            //var result = numbers.Last();

//            //Console.WriteLine("Last number in array is:");
//            //Console.WriteLine(result);

//            //    string[] words = { "one", "two", "three" };
//            //    string[] empty = { };

//            //    var result = words.LastOrDefault();

//            //    var resultEmpty = empty.LastOrDefault();

//            //    Console.WriteLine(result);

//            //    Console.WriteLine(resultEmpty == null);



//            //    string[] names1 = { "Peter" };
//            //    string[] names3 = { "Peter", "Joe", "Wilma" };
//            //    string[] empty = { };

//            //    var result1 = names1.Single();

//            //    Console.WriteLine("The only name in the array is:");
//            //    Console.WriteLine(result1);

//            //    try
//            //    {
//            //        // This will throw an exception because array contains no elements
//            //        var resultEmpty = empty.Single();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }

//            //    try
//            //    {
//            //        // This will throw an exception as well because array contains more than one element
//            //        var result3 = names3.Single();
//            //    }
//            //    catch (Exception e)
//            //    {
//            //        Console.WriteLine(e.Message);
//            //    }
//            //}

//            List<string> words = new List<string> { "Basket", "Blueberry", "Chimpanzee", "Abacus", "Banana", "Apple", "Cheese" };
//            var wordgroups = words.GroupBy(x => x.Length).Select(y => new { firstLetter = y.Key, words = y });
//            foreach (var item in wordgroups)
//            {

//                foreach (var w in item.words)
//                {
//                    Console.WriteLine(w);
//                }
//            }

//        }
//        public static void Main()
//        {
//            func();
//        }

//    }
//}

