//Write a program that reads an integer number and calculates and prints its square root.
//If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class PrintSquare
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        string number = Console.ReadLine();
        try
        {
            long answer = PrintSqr(number);
        }
        catch (FormatException fe)
        {
            Console.WriteLine(fe.Message);
        }
        catch (IndexOutOfRangeException ie)
        {
            Console.WriteLine(ie.Message);
        }
        finally
        {
            Console.WriteLine("Good bye");
        }    
    }


    static long PrintSqr(string str)
    {
        int n = Int32.Parse(str);
        if (n < 0)
        {
            throw new IndexOutOfRangeException("Invalid number"); 
        }
        return n * n;
    }
}
