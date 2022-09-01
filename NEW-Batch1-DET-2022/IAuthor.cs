using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal interface IEMail
    {
        string SendEMail();
    }

    public interface INotify
    {
        string SendSMS();
    }

    public class Author : IEMail, INotify
    {
        public string Name { get; set; }
        public string EMail { get; set; }
        public char Gender { get; set; }

        public string SendEMail()
        {
            return $"Mail sent to {Name}, {EMail},{Gender}";
        }

        public string SendSMS()
        {
            return $"{Name} subscribed SMS notifications";
        }
    }

    class SITLAuthor : Author, IEMail
    {
        public string SendEMail()
        {
            return $"mail sent to Name={Name}, EMail={EMail},Gender={Gender}";
        }
    }

    class TestIAuthor
    {
        public static void Main()
        {
            Author a = new Author { Name = "Ani", EMail = "ani", Gender = 'M' };
            SITLAuthor sa = new SITLAuthor { Name = "Anirudha", EMail = "anirudha.p", Gender = 'M' };

            Console.WriteLine(a.SendEMail());
            Console.WriteLine(a.SendSMS());
            Console.WriteLine(sa.SendEMail());
        }
    }
}
