using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        string exp = Console.ReadLine();
        decimal sum = 0;
        char symbol = '+';
        StringBuilder number = new StringBuilder();
        for (int i = 0; i < exp.Length; i++)
        {
            if(exp[i] >= '0' && exp[i] <='9')
            {
                number.Append(exp[i]);
            }
            else if( exp[i] == '+' || exp[i] == '-' || exp[i] == '%' || exp[i] == '*' )
            {
                sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
                number = new StringBuilder();
                symbol = exp[i];
            }
            else if( exp[i] == '(')
            {
                string current = InScope(exp, ref i);
                number.Append(current);
            }
            else if (exp[i] == '=')
            {
                sum = Calculate(sum, int.Parse(number.ToString()), symbol);
            }
        }
        Console.WriteLine("{0:F3}", sum);
    }

    private static decimal Calculate(decimal sum, decimal p, char symbol)
    {
        if (symbol == '+')
        {
            return sum + p;
        }
        else if (symbol == '-')
        {
            return sum - p;
        }
        else if (symbol == '%')
        {
            return sum % p;
        }
        return sum * p;
    }

    private static string InScope(string exam, ref int i)
    {
        StringBuilder number = new StringBuilder();
        decimal sum = 0;
        char symbol = '+';
        i++;
        while (exam[i] != ')')
        {
            if (exam[i] >= '0' && exam[i] <= '9')
            {
                number.Append(exam[i]);
            }
            else if (exam[i] == '+' || exam[i] == '-' || exam[i] == '*' || exam[i] == '%')
            {
                sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
                number = new StringBuilder();
                symbol = exam[i];
            }
            i++;
        }
        sum = Calculate(sum, decimal.Parse(number.ToString()), symbol);
        return sum.ToString();
    }

}

