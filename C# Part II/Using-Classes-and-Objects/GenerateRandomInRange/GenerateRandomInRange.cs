using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GenerateRandomInRange
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(RandomGenerator.randomGenerator.Next(100,200));
        }
    }

    static class RandomGenerator
    {
       public static Random randomGenerator = new Random();
    }

}

