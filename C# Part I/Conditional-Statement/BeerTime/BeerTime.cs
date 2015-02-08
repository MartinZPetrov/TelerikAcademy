﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
//Examples:

//time	result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time
class BeerTime
{
    static CultureInfo provider = CultureInfo.InvariantCulture;
    static DateTime evening = DateTime.ParseExact("01:00 PM", "hh:mm tt", provider);
    static DateTime morning = DateTime.ParseExact("03:00 AM", "hh:mm tt", provider);
    static void Main(string[] args)
    {
      
            try
            {
                Console.WriteLine("Enter time in format hh:mm tt");
                DateTime time = DateTime.ParseExact(Console.ReadLine(), "h:mm tt", provider);
                Console.WriteLine(IsBeerTime(time) ? "beer time" : "non-beer time");
            }
            catch (FormatException e)
            {
                Console.WriteLine("invalid time");
            }
        }
        private static bool IsBeerTime(DateTime time)
        {
            bool afterEvening = time.TimeOfDay.CompareTo(evening.TimeOfDay) >= 0;
            bool beforeMorning = time.TimeOfDay.CompareTo(morning.TimeOfDay) < 0;
            return afterEvening || beforeMorning;
        }
    }
}
