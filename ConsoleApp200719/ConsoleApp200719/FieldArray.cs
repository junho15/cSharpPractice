using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp200719
{
    class Schedule
    {
        private string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        public void PrintWeekDays()
        {
            foreach (var day in weekDays)
            {
                Console.Write($"{day}\t");
            }

            Console.WriteLine();
        }
    }

    class FieldArray
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.PrintWeekDays();
        }
    }
}
