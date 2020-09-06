using System;

namespace ConsoleApp200723
{

    class MethodAndParameter
    {
        static void Main(string[] args)
        {
            string title;
            var car = new Car();
            car.Map(out title);
            Console.WriteLine($"[3] {title}");
        }
    }
}
