using System;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp200825
{
    public class LuxuryAttribute : Attribute 
    {
        public LuxuryAttribute()
        {
            Console.WriteLine("럭셔리!!!");
        }
    }

    [Luxury]
    class Car
    {
        [Obsolete("다음 버전에 제거될 예정이니 Auto()를 사용하세요.")]
        public void Manual() => Console.WriteLine("수동 운전");
        public void Auto() => Console.WriteLine("자동 운전");
        [Conditional("DEBUG")]
        public void Test() => Console.WriteLine("테스트 운전");
    }

    class AttributeDemo
    {
        static void Main(string[] args)
        {
            var car = new Car();
            Attribute.GetCustomAttributes(typeof(Car));
            typeof(Car).GetCustomAttributes(false);
            car.Manual();
            car.Auto();
            car.Test();
            // 리플렉션
            var carType = (new Car());
            Type myCar = carType.GetType();
            MethodInfo info = myCar.GetMethod("Auto");
            info.Invoke(carType, null);

        }
    }
}
