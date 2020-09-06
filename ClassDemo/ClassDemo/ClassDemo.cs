using System;

namespace ClassDemo
{
    class ClassDemo
    {
        static void Main(string[] args)
        {
            ClassOne.Hi();
            ClassTwo.Hi();

            ClassTwo ct = new ClassTwo();
            ct.Hello();
        }
    }
}
