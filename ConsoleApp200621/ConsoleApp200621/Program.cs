using System;

namespace ConsoleApp200621
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write($"{j} * {i} = {i * j, 2}   ");
                }

                Console.WriteLine();
            }
        }
    }
}
