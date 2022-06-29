using System;

namespace Fibonacci_numbers_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0, n;
            int a = 0, b = 1, c = 0;

            Console.WriteLine("Enter the Numer: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);

          

            while (i <= n)
            {
                c = a + b;
                a = b;
                b = c;
                i = i + 1;
                Console.WriteLine(c);
            }
        }
    }
}
