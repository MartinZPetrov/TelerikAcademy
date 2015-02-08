using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task2
{
    static void Main()
    {
        int M = Int32.Parse(Console.ReadLine());
        string text = Console.ReadLine();
        decimal result = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if(Char.IsDigit(text[i]))
            {
                string digitStr = text[i].ToString();
                var digitnum = digitStr.Select(e => Int32.Parse(e.ToString())).ToArray();
                result *= digitnum[0];
            }
            else if(Char.IsLetter(text[i]))
            {
                char letter = text[i];
                string nonCaseLetter = new string(new char[] { letter }).ToUpper();
                var noneCaseChar = nonCaseLetter.ToCharArray();
                int position = nonCaseLetter[0] - 65;
                result += position;
            }
            else
            {
                if (Char.Equals(text[i], '@'))
                {
                    break;
                }
                result %= M;
            }
        }
        Console.WriteLine(result);
    }
}

