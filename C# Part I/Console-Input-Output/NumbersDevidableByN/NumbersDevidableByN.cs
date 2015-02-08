using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 11.* Numbers in Interval Dividable by Given Number

//Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
//Examples:

//start	end	p	comments
//17	25	2	20, 25
//5	30	6	5, 10, 15, 20, 25, 30
//3	33	6	5, 10, 15, 20, 25, 30
//3	4	0	-
//99	120	5	100, 105, 110, 115, 120
//107	196	18	110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
class NumbersDevidableByN
{
    static void Main(string[] args)
    {

        Console.Write("Enter the first number: ");
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            start ^= end;
            end ^= start;
            start ^= end;
        }

        int count = 0;

        for (int number = start; number <= end; number++)
            if (number % 5 == 0)
                ++count;

        Console.WriteLine(count);
    }
}
