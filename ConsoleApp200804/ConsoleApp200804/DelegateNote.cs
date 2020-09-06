using System;

namespace ConsoleApp200804
{
    class DelegateNote
    {
        delegate void SayPointer();

        static void Hello() => Console.WriteLine("Hello Delegate");

        static void Main(string[] args)
        {
            SayPointer sayPointer = new SayPointer(Hello);

            sayPointer();
            sayPointer.Invoke();
        }
    }
}
