using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

//Examples:

//n	sum of digits	reversed	last digit in front	second and third digits exchanged
//2011	4	1102	1201	2101
//3333	12	3333	3333	3333
//9876	30	6789	6987	9786
class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        string number = Console.ReadLine();

        if(number.Count() != 4)
        {
            Console.WriteLine("Must be 4 numbers");
            Environment.Exit(0);
        }

        if(Int32.Parse(number.Substring(0,1)) == 0)
        {
            Console.WriteLine("Number must nost start with 0");
            Environment.Exit(0);
        }

        var intArray = number.Select(e => Int32.Parse(e.ToString())).ToArray();
        int sum = intArray.Sum();
        Array.Reverse(intArray);
        string resultRev = String.Join("", intArray);
        string firstAndLastSwapped = SwapLastAndFirst(intArray);
        string secondAndThirdSwapped = SwapSecondAndThirdDigits(intArray);

        Console.WriteLine("{0} {1} {2} {3} {4}", number, sum, resultRev, secondAndThirdSwapped, firstAndLastSwapped);

    }

    static string SwapLastAndFirst(int[] array)
    {
        return array[3].ToString() + array[1].ToString() + array[2].ToString() + array[0].ToString();
    }

    static string SwapSecondAndThirdDigits(int[] array)
    {
        return array[0].ToString() + array[3].ToString() + array[2].ToString() + array[1].ToString();
    }
     
}

