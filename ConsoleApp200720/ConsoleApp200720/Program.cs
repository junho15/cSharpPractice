using System;

namespace ConsoleApp200720
{
    public class Car
    {
        private readonly string name;

        public Car() : this("기본자동차") { }

        public Car(string name) => this.name = name;

        public void Go() => Console.WriteLine($"{name}가 달리다.");
    }

    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Go();
            Car my = new Car("좋은자동차");
            my.Go();
        }
    }
}
