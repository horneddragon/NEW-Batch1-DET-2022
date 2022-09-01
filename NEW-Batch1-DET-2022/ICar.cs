namespace ConsoleAppDemo
{
    internal interface ICarPrice
    {
        int GetPrice(string name);
    }

    class BMW : ICarPrice
    {
        public int GetPrice(string name)
        {
            if (name == "M3 GTR")
            {
                return 5000000;
            }
            else if (name == "X7")
            {
                return 90000000;
            }
            else
            {
                return 1000000;
            }
        }

    }
    class Audi : ICarPrice
    {
        public int GetPrice(string name)
        {
            if (name == "R8")
            {
                return 9000000;
            }
            else if (name == "Spyder")
            {
                return 9500000;
            }
            else
            {
                return 1000000;
            }
        }

    }








    class TestICar
    {
        public static void Main()
        {
            Audi a = new Audi();
           int price1 =  a.GetPrice("R8");
            Console.WriteLine(price1);
            BMW b = new BMW();
            int price2 = a.GetPrice("X7");

            Console.WriteLine(price2);
        }
    }
}
