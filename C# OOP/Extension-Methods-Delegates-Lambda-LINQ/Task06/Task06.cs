using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
    //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
    class Task06
    {
        static void Main(string[] args)
        {
            var arr = new int[]{1,7 ,21 ,14 };

            var res = arr.Where(e => e % 7 == 0 && e % 3 == 0);
            
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

            res = from items in arr
                  where items % 7 == 0 && items % 3 == 0
                  select items;

            foreach (var item in res)
            {
                Console.WriteLine(item);
            }

        }
    }
}
