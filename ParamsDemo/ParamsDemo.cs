
namespace ParamsDemo
{
    internal class ParamsDemo
    {

        public static int Sum(params int[] arr)
        {
            int sum = 0;
                foreach (int i in arr)
                     sum += i;
                return sum; 
        }
        public static void Main()
        {
            Console.WriteLine(Sum(1,2,3));
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }
    }

    internal class CatchError
    {

        public static int Sum(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
                sum += i;
            return sum;
        }
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter numbers");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(Sum(x));
            }
            catch(OverflowException)
            {
                Console.WriteLine("Enter number within limit");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter number not other datatype");
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown error occured");
            }
            
            Console.WriteLine(Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        }


    }

    public  class returnAge
    {
        public static int age(DateTime dob)
        {
            int CurrentYear = DateTime.Now.Year;
            int C = DateTime.Now.Month;
            return CurrentYear - dob.Year;

        }

        public static void Main()
        {
           
           
           DateTime date = DateTime.Parse(Console.ReadLine());
            int res = (age(date)); 
            Console.WriteLine($"your age is{res}");
        }
    }
}
