using System;
using System.Collections;

namespace ConsoleApp200821
{
    class IEnumeratorDemo
    {
        static void Main(string[] args)
        {
            string[] names = { "닷넷코리아", "비주얼아카데미" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            IEnumerator list = names.GetEnumerator();
            while (list.MoveNext())
            {
                Console.WriteLine(list.Current);
            }
        }
    }
}
