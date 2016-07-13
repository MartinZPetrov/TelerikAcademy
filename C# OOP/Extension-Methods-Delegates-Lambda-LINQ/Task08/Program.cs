using System;
using System.Collections.Generic;
//Problem 8.* Events

//Read in MSDN about the keyword event in C# and how to publish events.
//Re-implement the above using .NET events and following the best practices.

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            TimerPublisher pub = new TimerPublisher();
            pub.RaiseTimer += pub_RaiseTimer;
            pub.Start(1, 20);
        }

        static void pub_RaiseTimer(object sender, SampleArgs args)
        {
            Console.WriteLine(args.Message);
        }
    }
}