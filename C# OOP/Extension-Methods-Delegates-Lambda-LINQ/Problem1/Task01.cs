using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and
//has the same functionality as Substring in the class String.

namespace Problem1
{
       
    public static class Task01
    {

        static void Main()
        {
            var sb = new StringBuilder("This is just a text");
            var newSB = sb.SubString(0, 5);
            Console.WriteLine(newSB.ToString());
        }      
    }
}
