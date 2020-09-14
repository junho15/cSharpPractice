using System;
using System.Collections.Generic;

namespace ConsoleApp200914
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>() { "Red", "Blue" };
            foreach (var item in colors)
            {
                Console.WriteLine(item);
            }

            var categories = new List<Category>()
            {
                new Category() {CategoryId = 1, CategoryName = "좋은 책"},
                new Category() {CategoryId = 2, CategoryName = "좋은 강의"},
                new Category() {CategoryId = 3, CategoryName = "좋은 컴퓨터"}
            };

            foreach (var item in categories)
            {
                Console.WriteLine($"{item.CategoryId}.{item.CategoryName}");
            }

            var text = new Cup<string>();
            text.Content = "STRING";
            Console.WriteLine(text.Content);
        }
    }

    public class Cup<T>
    {
        public T Content { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
