using Microsoft.VisualBasic;
using System;
using System.Globalization;
using System.Linq.Expressions;

namespace ConsoleApp200626
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(4 * 3 * 2 * 1);
            Console.WriteLine(FactorialFor(4));
            Console.WriteLine(Factorial(4));
            Console.WriteLine(Fact(4));
        }

        static int Fact(int n)
        {
            return (n > 1) ? n * Fact(n - 1) : 1;
        }

        static int Factorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        static int FactorialFor(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
