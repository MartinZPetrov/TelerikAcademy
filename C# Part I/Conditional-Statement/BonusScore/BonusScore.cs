using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

class BonusScore
{
    static void Main()
    {
        int number;

        Console.Write("Enter number: ");
        number = int.Parse(Console.ReadLine());
        Console.WriteLine("Score    Number");
        if(number >=1 && number <= 3)
        {
            Console.WriteLine("{0}       {1}",number, number*10);
        }
        else if(number >=4 && number <= 6)
        {
            Console.WriteLine("{0}       {1}", number, number * 100);
        }
        else if (number >=7 && number <= 9) 
        {
            Console.WriteLine("{0}        {1}", number, number * 1000);
        }
        else
        {
            Console.WriteLine("Invalid score");
        }

    }
}
