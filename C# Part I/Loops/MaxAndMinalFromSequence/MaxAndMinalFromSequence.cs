//Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

using System;

class MaxAndMinalFromSequence
{
    static void Main()
    {
        int n;
        double number, sum,min,max;
        max = 0;
        sum = 0;
        
        min = Int32.MaxValue;
        Console.Write("n: ");
        n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Your number: ");
            number = double.Parse(Console.ReadLine());

            if (number > max)
            {
                max = number;
            }
            sum += number;
            if (number < min)
            {
                min = number;
            }
        }

        Console.WriteLine("Sum: {0}", sum);
        Console.WriteLine("Average: {0:F2}", sum/n );
        Console.WriteLine("Min: {0}", min);
        Console.WriteLine("Max: {0}", max);
    }
}

