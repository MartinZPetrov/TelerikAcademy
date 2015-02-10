/*Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. 
 * If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
 a1, a2, … a10, such that 1 < a1 < … < a10 < 100
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class ReadNumber
{
    static void Main(string[] args)
    {
        
        try
        {
            Console.WriteLine("Enter start number: ");
            int start = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number: ");
            int end = Int32.Parse(Console.ReadLine());
            ReadNumbers(start, end);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (ArgumentOutOfRangeException ie)
        {
            Console.WriteLine("Error " + ie.Message);
        }
    }

    static void ReadNumbers(int start, int end )
    {
        for (int i = 0; i < 9; i++)
        {
            int numb = Int32.Parse(Console.ReadLine());
            if (numb < start || numb > end)
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}

