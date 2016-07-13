using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program to return the string with maximum length from an array of strings.
//Use LINQ.
namespace Task17
{
    public class LongestStringProgram
    {
        public static string FindLongestString(IList<string> arr)
        {
            return arr.OrderByDescending(x => x.Length).First();
        }

        public static void Main()
        {
            string[] stringArray = new string[]
            {
                "Not longest string",
                "Probably the longest string",
                "Lorem ipsum",
                "This is the longest string in the array"
            };

            var longest = FindLongestString(stringArray);

            Console.WriteLine(longest);
        }
    }
}
