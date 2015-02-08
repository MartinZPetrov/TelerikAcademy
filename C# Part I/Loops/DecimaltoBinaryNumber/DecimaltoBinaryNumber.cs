using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Decimal to Binary Number
//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:
//decimal	binary
//0	0
//3	11
//43691	1010101010101011
//236476736	1110000110000101100101000000
class DecimaltoBinaryNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number must be positive.");
            return;
        }

        Console.WriteLine("{0} -> {1}", number, ToBinary(number));
    }
    public static string ToBinary(int number)
    {
        if (number == 0) return number.ToString();

        string binary = String.Empty;
        int result = number;
        while (result > 0)
        {
            binary += (result % 2).ToString();
            result /= 2;
        }
        return ReverseString(binary);
    }
    public static string ReverseString(string binary)
    {
        var temp = binary.ToCharArray();
        Array.Reverse(temp);
        return new String(temp);
    }

}
