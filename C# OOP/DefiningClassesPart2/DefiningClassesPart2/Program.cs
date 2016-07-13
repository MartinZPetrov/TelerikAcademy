using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Path loadedPath = PathStorage.LoadPath(@"../../pathsample.txt"); //loading the saved file and printing the points

            for (int i = 0; i < loadedPath.PathList.Count; i++)
            {
                Console.WriteLine(loadedPath.PathList[i]);
            }
        }
    }
}
