using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var gsms = GSMTest.GenerateGSMs(5);
            GSMTest.PrintGSMsInfo(gsms);

                
            //problem 12
            GSMCallHistoryTest.CreateCalls();
            GSMCallHistoryTest.DisplayCalls();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();
            GSMCallHistoryTest.RemoveLongestCall();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0}\n{1}", "Price after the longest call is removed: ", new string('-', 50));
            GSMCallHistoryTest.CalculateAndPrintTestcallsPrice();
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("{0}\n{1}", "Call history after the longest call is removed: ", new string('-', 50));
            GSMCallHistoryTest.DisplayCalls();
            Console.WriteLine(new string('-', 50));
            GSMCallHistoryTest.testGSM.DeleteCallHistory();
            Console.WriteLine("{0}\n{1}", "Call history list is cleared...", new string('-', 50));
            GSMCallHistoryTest.DisplayCalls();
        }
    }
}
