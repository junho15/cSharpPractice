using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp200804
{
    class AnonymousDelegate
    {
        delegate void SayDelegate();

        static void Main(string[] args)
        {
            SayDelegate say = delegate ()
            {
                Console.WriteLine("반갑습니다.");
            };
            say();
        }
    }
}
