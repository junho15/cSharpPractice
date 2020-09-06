using System;

namespace ConsoleApp200719
{
    public class Persion
    {
        private string name = "이준호";
        private const int m_age = 29;
        private readonly string _NickName;
        private string[] _websites = { "닷넷코리아", "비주얼아카데미" };

        public Persion()
        {
            _NickName = "RedPlus";
        }

        public void ShowProfile()
        {
            Console.WriteLine($"{name} = {string.Join(", ", _websites)}");
        }

    }

    public class Program
    {
        private static string message = "안녕하세요.";

        public static void Hi() => Console.WriteLine(message);

        static void Main(string[] args)
        {
            int number = 1_234; // 변수, 지역 변수
            Console.WriteLine(number);
            Console.WriteLine(message);
            Hi();

            var say = new Say();
            say.Hi();

            Persion me = new Persion();
            me.ShowProfile();
        }
    }
}
