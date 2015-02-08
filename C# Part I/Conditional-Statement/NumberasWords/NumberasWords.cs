using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//Examples:
//numbers	number as words
//0	Zero
//9	Nine
//10	Ten
//12	Twelve
//19	Nineteen
//25	Twenty five
//98	Ninety eight
//98	Ninety eight
//273	Two hundred and seventy three
//400	Four hundred
//501	Five hundred and one
//617	Six hundred and seventeen
//711	Seven hundred and eleven
//999	Nine hundred and ninety nine
class NumberasWords
{
    static void Main(string[] args)
    {
        int number, tens, digits, hundreds;

        Console.WriteLine("Enter a digit  between 0 and 999");
        number = Int32.Parse(Console.ReadLine());
        string text = "";
        digits = number % 10;
        tens = number % 100;
        hundreds = number / 100;

        if (hundreds != 0) // get hundreds
        {
            switch (hundreds)
            {
                case 1: text += "One hundred "; break;
                case 2: text += "Two hundred "; break;
                case 3: text += "Thre hundred "; break;
                case 4: text += "Four hundred "; break;
                case 5: text += "Five hundred "; break;
                case 6: text += "Six hundred "; break;
                case 7: text += "Sven hundred "; break;
                case 8: text += "Eight hundred "; break;
                case 9: text += "Nine hundred "; break;
                default:
                    break;
            }


            if (tens / 10 == 0 && digits != 0)
            {
                text += "and";
                switch (digits)
                {

                    case 0: text += "zero"; break;
                    case 1: text += "one"; break;
                    case 2: text += "two"; break;
                    case 3: text += "three"; break;
                    case 4: text += "four"; break;
                    case 5: text += "five"; break;
                    case 6: text += "six"; break;
                    case 7: text += "seven"; break;
                    case 8: text += "eight"; break;
                    case 9: text += "nine"; break;
                    default:
                        break;
                }
            }
        }

        if (tens < 20) // get teen numbers
        {
            if (hundreds != 0)
            {
                text += "and ";
            }

            switch (tens)
            {
                case 10: text += "ten"; break;
                case 11: text += "eleven"; break;
                case 12: text += "twleve"; break;
                case 13: text += "thirteen"; break;
                case 14: text += "fourteen"; break;
                case 15: text += "fifteen"; break;
                case 16: text += "sixteen"; break;
                case 17: text += "seventeen"; break;
                case 18: text += "eighteen"; break;
                case 19: text += "nineteen"; break;
                default:
                    break;
            }

        }
        else
        {
            switch (tens / 10)
            {
                case 2: text += "twenty "; break;
                case 3: text += "thirty "; break;
                case 4: text += "fourty "; break;
                case 5: text += "fifty"; break;
                case 6: text += "sixty"; break;
                case 7: text += "seventy "; break;
                case 8: text += "eighty "; break;
                case 9: text += "ninety "; break;
                default:
                    break;
            }

            if (digits != 0)
            {
                switch (digits)
                {
                    case 1: text += "one"; break;
                    case 2: text += "two"; break;
                    case 3: text += "three"; break;
                    case 4: text += "four"; break;
                    case 5: text += "five"; break;
                    case 6: text += "six"; break;
                    case 7: text += "seven"; break;
                    case 8: text += "eight"; break;
                    case 9: text += "nine"; break;
                    default:
                        break;
                }
            }

        }
        if (hundreds == 0 && tens / 10 == 0) // if we dont have hundreds and twenties
        {
            switch (digits)
            {
                case 0: text += "zero"; break;
                case 1: text += "one"; break;
                case 2: text += "two"; break;
                case 3: text += "three"; break;
                case 4: text += "four"; break;
                case 5: text += "five"; break;
                case 6: text += "six"; break;
                case 7: text += "seven"; break;
                case 8: text += "eight"; break;
                case 9: text += "nine"; break;
                default:
                    break;
            }
        }
        Console.WriteLine("{0} -> {1}", number, text);
    }
}

