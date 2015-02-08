//Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.
using System;

class OneToNWithout3And7
{
    static void Main()
    {
        int number;
        number = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < number; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            else
            {
                Console.Write(i + " ");
            }

        }
    }
}

