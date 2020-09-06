using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp200722
{
    class Car
    {
        public Car()
        {
            Console.WriteLine("생성, 조립, 시동");
        }

        public void Go() => Console.WriteLine("달리다.");

        ~Car()
        {
            Console.WriteLine("소멸");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Go();
            Car car2 = new Car();
            car2.Go();
            Car car3 = new Car();
            car3.Go()
        }
    }
}
