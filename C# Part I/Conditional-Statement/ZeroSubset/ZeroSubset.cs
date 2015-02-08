using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0.
//Assume that repeating the same subset several times is not a problem.
//Examples:

//numbers	result
//3 -2 1 1 8	-2 + 1 + 1 = 0
//3 1 -7 35 22	no zero subset
//1 3 -4 -2 -1	1 + -1 = 0
//1 + 3 + -4 = 0
//3 + -2 + -1 = 0
//1 1 1 -1 -1	1 + -1 = 0
//1 + 1 + -1 + -1 = 0
//0 0 0 0 0	0 + 0 + 0 + 0 + 0 = 0
//Hint: you may check for zero each of the 32 subsets with 32 if statements.
namespace ZeroSubset
{
    class ZeroSubset
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers separated by space: ");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ', '\t', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter sum: ");
            int sum = 0;

            List<string> allSubsets = new List<string>();


            SubsetSumGenerator generator = new SubsetSumGenerator(sum, numbers);
            allSubsets = generator.GetAllSums();
            if (allSubsets.Count == 0) allSubsets.Add("No subset sums found!");


            Console.Clear();
            allSubsets = allSubsets.Distinct().ToList();
            Console.WriteLine("All subsets: \n");
            Console.WriteLine(string.Join("\n", allSubsets));
        }
    }
}

