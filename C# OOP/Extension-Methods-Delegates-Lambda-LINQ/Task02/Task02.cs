using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    //Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
    class Task02
    {
        static void Main(string[] args)
        {
            var list = new List<double>(new[] { 1.1, 2.2, 3.3, 4.4 });

            Console.WriteLine(list.Max()) ;
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Product());
            Console.WriteLine(list.Avarage());
            Console.WriteLine(list.Sum());
        }
    }
}
