using ConsoleAppDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW_Batch1_DET_2022
{
    internal class Book
    {
        public string Name { get; set; }
        public int price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }

        public override string ToString()
        {
            return $"{Name},{author.ToString()},{price},{Qty}";
        }

    }


    public class TextBook
    {
        public static void Main()
        {
            Book book = new Book
            {
                Name = "Book",
                author = new Author { Name = "Ani", EMail = "@gmail", Gender = 'M' },
                price = 500,
                Qty = 5
            };
            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            Book dummyBook = new Book { Name = "C#", author = alex, price = 19, Qty = 99 };

            int? i = null;
            if (i.HasValue)
            {
                Console.WriteLine("is null");

            }
            else { Console.WriteLine("not null"); }
        }

    }
}
