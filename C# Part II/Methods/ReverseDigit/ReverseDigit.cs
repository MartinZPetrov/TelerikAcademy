//Write a method that reverses the digits of given decimal number. Example: 256  652
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseDigit
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        decimal number = Int32.Parse(Console.ReadLine());
        Console.Write("Reversed: ");
        decimal reversed = ReverseDecimal(number);
        Console.Write(reversed);
    }

    static decimal ReverseDecimal(decimal number)
    {
        return decimal.Parse(new string(number.ToString().ToCharArray().Reverse().ToArray()));
    }
}
