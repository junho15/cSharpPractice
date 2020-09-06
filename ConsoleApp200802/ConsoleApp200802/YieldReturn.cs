using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp200802
{
    class YieldReturn
    {
        static IEnumerable MultiData()
        {
            yield return "Hello";
            yield return "World";
            yield return "C#";
        }

        static void Main(string[] args)
        {
            foreach (var item in MultiData())
            {
                Console.WriteLine(item);
            }
        }
    }
}

