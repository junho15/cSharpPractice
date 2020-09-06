using System;
using static System.Console;
using static System.Math;

namespace ConsoleApp200614
{
    class Program
    {
        static void Main()
        {
            if (decimal.TryParse("123.5", out decimal result))
            {
                Console.WriteLine(result);
            }
        }
    }
}
