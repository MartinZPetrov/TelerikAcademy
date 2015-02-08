/*
Write a boolean expression that checks for given integer 
if it can be divided (without remainder) by 7 and 5 in the same time.
*/
using System;

class IntegerWihoutRemainder
{
    static void Main()
    {
        int number = 35;
        bool isRemainder = ((number % 5) == 0) && ((number % 7) == 0);  //check if the numbers has a remainder when devided by 5 and 7
        if (isRemainder)
        {
            Console.WriteLine("The numbers {0} when divided by 7 and 5 has no remainder", number);
        }
        else 
        {
            Console.WriteLine("The numbers {0} when divided by 7 and 5 has a remainder", number);
        }
    
    }
}

