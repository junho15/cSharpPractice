using System;

namespace ConsoleApp200728
{
    class Car
    {
        public string Name { get; set; } = "Your Car";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.WriteLine(car.Name);
            car.Name = "My Car";
            Console.WriteLine(car.Name);
        }
    }
}
