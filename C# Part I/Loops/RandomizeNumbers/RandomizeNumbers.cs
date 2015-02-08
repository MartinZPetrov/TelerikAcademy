using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:
//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.
class RandomizeNumbers
{
    static void Main()
    {
         Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            bool increment = number >= 1;
            List<int> numbers = GetNumbers(number, increment);
            Random random = new Random();

            var result = numbers.OrderBy(item => random.Next());

            Console.WriteLine(string.Join(", ", result));
        }
        private static List<int> GetNumbers(int number, bool increment)
        {
            List<int> numbers = new List<int>();
            if (number == 0)
            {
                numbers.Add(1);
                numbers.Add(0);
            }
            else
            {
                for (int i = 1; Math.Abs(i) <= Math.Abs(number); )
                {
                    numbers.Add(i);
                    if (increment) ++i;
                    else --i;
                }
            }
            return numbers;
        }
    }
}

