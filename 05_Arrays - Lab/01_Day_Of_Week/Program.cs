﻿using System;

namespace _01_Day_Of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = new String[]
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            int day = int.Parse(Console.ReadLine());

            if (day >= 1 && day <= 7)
            {
                Console.WriteLine($"{dayOfWeek[day - 1]}");
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
