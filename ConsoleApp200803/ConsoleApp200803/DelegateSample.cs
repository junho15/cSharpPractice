using System;

namespace ConsoleApp200803
{
    class DelegateSample
    {
        static void GoForward() => Console.WriteLine("직진");
        static void GoLeft() => Console.WriteLine("좌회전");
        static void GoFast() => Console.WriteLine("과속");
        // static void GoRight() => Console.WriteLine("우회전");

        delegate void CarDriver();  // 대리자 생성

        static void Main(string[] args)
        {
            GoForward();

            CarDriver goHome = new CarDriver(GoForward);
            goHome += GoLeft;
            goHome += GoFast;
            goHome -= GoLeft;
            // 무명 메서드 / 익명 함수
            goHome += delegate () { Console.WriteLine("우회전"); };
            //goHome += delegate () { Console.WriteLine("후진"); };
            goHome += () => Console.WriteLine("후진");

            goHome();   // goHome.Invoke();

            Console.WriteLine();

            // 내장된 대리자 형식 : Func<T>, Action<T>, Predicate<T>, ...
            Action driver = GoForward;
            driver += GoLeft;
            driver += () => Console.WriteLine("후진");
            driver();   //트리거

            Console.WriteLine();

            RunLamda(() => Console.WriteLine("매개 변수로 람다식 전달"));
        }

        static void RunLamda(Action action) => action();
    }
}
