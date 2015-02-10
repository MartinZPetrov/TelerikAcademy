/*Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d).
Example of incorrect expression: )(a+b)).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckExpression
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string str = Console.ReadLine();
        Console.WriteLine("Expression correct ? ---> {0}", CheckIfCorrectExpr(str));

    }

    public static bool CheckIfCorrectExpr (string str)
    {
        if (str.IndexOf('(') > str.IndexOf(')'))
        {
            return false; 
        }
        return true;
    }
}

