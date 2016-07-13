using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tak07
{
    // Using delegates write a class Timer that can execute certain method at each t seconds
    
    class Task07
    {
        static void Main(string[] args)
        {
            var timer = new Timer(5);
            timer.DelHandler += BlqBblq;
            timer.DelHandler += BlqBlq2SorryBlq;
            timer.execute();
        }


        private static void BlqBblq()
        {
            Console.WriteLine("BlqBlq");
        }

        private static void BlqBlq2SorryBlq()
        {
            Console.WriteLine("BlqBLq2SorryBlq");
        }
    }
}
