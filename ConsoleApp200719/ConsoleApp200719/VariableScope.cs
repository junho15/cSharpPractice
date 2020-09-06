using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp200719
{
    class VariableScope
    {
        static string globalVariable = "전역 변수";

        static void Main(string[] args)
        {
            string localVariable = "지역 변수";
            Console.WriteLine(localVariable);
            Console.WriteLine(globalVariable);

            Test();
        }

        static void Test() => Console.WriteLine(globalVariable);
    }
}
