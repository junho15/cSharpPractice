using System;

namespace PropertyNote
{
    class Program
    {
        static void Main(string[] args)
        {
            Car.Color = "Black";
            Car.Type = "세단";
            Console.WriteLine($"차종 : {Car.Type}, 색상 : {Car.Color}");

            Person person = new Person("박용준");
            person.BirthYear = (DateTime.Now.Year - 21);
            Console.WriteLine($"이름 : {person.Name}, 나이 : {person.Age}");
        }
    }
}
