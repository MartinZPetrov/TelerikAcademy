using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.AgeAfter10Years
{
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter current age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Age after 10 years will be \n{0}: ", age+10);
        }
    }
}
