//Write an expression that checks if given integer is odd or even.
using System;

class CheckOddOrEvenInteger
{
    static void Main()
    {
        int number = 7;
        if ((number & 1) == 0)    //If the last bit of the number is 1 the number is odd
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            Console.WriteLine("The number is odd");
        }
    }
}

