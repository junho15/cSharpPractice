using System;

namespace ConsoleApp200723
{
    public class Car
    {
        public void Map(out string title)
        {
            title = "참조반환";
            Console.WriteLine($"{title}");
        }
    }
}
