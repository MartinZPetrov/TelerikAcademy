//Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LastDigitAsString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = Int32.Parse(Console.ReadLine());
        string lastDigit = GetDigit(number);

        Console.WriteLine(number + " -> " + lastDigit);
    }

    static string GetDigit(int number)
    {
        string lastDigit = number.ToString();
        int lenght = lastDigit.Length;
        lastDigit =  lastDigit.Substring(lenght - 1);

        switch (lastDigit)
        {
            case "1":
                lastDigit = "One";
                break;
            case "2":
                lastDigit = "Two";
                break;
            case "3":
                lastDigit = "Three";
                break;
            case "4":
                lastDigit = "Four";
                break;
            case "5":
                lastDigit = "Five";
                break;
            case "6":
                lastDigit = "Six";
                break;
            case "7":
                lastDigit = "Seven";
                break;
            case "8":
                lastDigit = "Eight";
                break;
            case "9":
                lastDigit = "Nine";
                break;
            case "0":
                lastDigit = "Zero";
                break;
            default:
                break;
        }
        return lastDigit;
    }
}

