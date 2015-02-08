using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 13. Binary to Decimal Number
//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:
//binary	decimal
//0	0
//11	3
//1010101010101011	43691
//1110000110000101100101000000	236476736
class BinarytoDecimalNumber
{

    static void Main(string[] args)
    {
        Console.Write("Enter binary number: ");
        string binary = Console.ReadLine().Trim();

        Console.WriteLine("Traditional way: " + ConvertToDecimal(binary));
    }

    public static int ConvertToDecimal(string binary)
    {
        int decimalNumber = 0;

        for (int bit = binary.Length - 1, pow = 0; bit >= 0; bit--, pow++)
        {
            decimalNumber += int.Parse(binary[bit].ToString()) * (int)Math.Pow(2, pow);
        }
        return decimalNumber;
    }
}



