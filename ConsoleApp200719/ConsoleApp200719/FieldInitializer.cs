using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp200719
{
    class Say
    {
        private string message = "안녕하세요.";

        public void Hi()
        {
            this.message = "반갑습니다.";
            Console.WriteLine(this.message);
        }
    }

    class FieldInitializer
    {
        static void Main(string[] args)
        {
            Say say = new Say();
            say.Hi();
        }
    }
}
