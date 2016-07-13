﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GSMCallHistoryTest
    {

        public static GSM testGSM = new GSM("MyGsm", "TheBest");

        public static DateTime testCall1Date = DateTime.Parse("08/03/2015 19:15:30");
        public static DateTime testCall2Date = DateTime.Parse("09/03/2015 14:07:18");
        public static DateTime testCall3Date = DateTime.Parse("10/03/2015 08:15:55");

        public static Call[] testCalls = {
                                         new Call(testCall1Date, 30, "0888111111"),
                                         new Call(testCall2Date, 40, "0888222222"),
                                         new Call(testCall3Date, 50, "0888333333"),
                                         };



        public static void CreateCalls()
        {
            for (int i = 0; i < testCalls.Length; i++)
            {

                testGSM.AddCall(testCalls[i]);
            }
        }


        public static void DisplayCalls()
        {
            Console.WriteLine(testGSM.PrintCallHistory());
        }

        public static void CalculateAndPrintTestcallsPrice()
        {
            decimal price = testGSM.GetTotalCallPrice(0.37m);//using method of the GSM class
            Console.WriteLine("Total price of test calls: {0:F2}", price);
        }

        public static void RemoveLongestCall()
        {
            Call longestCall = testGSM.CallHistory.OrderBy(x => x.Duration).ToArray()[testGSM.CallHistory.Count - 1]; //getting the longest call from the list of calls
            testGSM.DeleteCall(longestCall); //using method of the GSM class
        }

    }
}
