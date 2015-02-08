//Write an expression that checks for given integer 
//if its third digit (right-to-left) is 7. E. g. 1732 -> true.
using System;

class CheckIfDigitEqulasSeven
{
    static void Main()
    {
        int number = 9999799;
        bool isSeven = ((number % 1000) / 100 == 7); //gets the third digit 
        Console.Write("The third digit of {0} is 7 -> {1}", number, isSeven);
    }
}
