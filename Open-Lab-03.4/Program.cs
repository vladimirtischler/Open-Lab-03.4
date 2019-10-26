using System;

namespace Open_Lab_03._4
{
    class Program
    {
        public static string EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
        }
        static void Main(string[] args)
        {
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(EvenOrOdd(b));
        }
    }
}
