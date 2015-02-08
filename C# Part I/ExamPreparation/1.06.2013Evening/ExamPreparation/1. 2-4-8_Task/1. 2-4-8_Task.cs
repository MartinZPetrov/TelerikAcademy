using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        decimal A = decimal.Parse(Console.ReadLine());
        decimal B = decimal.Parse(Console.ReadLine());
        decimal C = decimal.Parse(Console.ReadLine());

        decimal R = 0;

        if (B == 2)
        {
            R = A % C;
        }
        else if (B == 4)
        {
            R = A + C;
        }
        else
        {
            R = A * C;
        }

        if (R % 4 == 0)
        {
            Console.WriteLine(R / 4);
        }
        else
        {
            Console.WriteLine(R % 4);
        }
        Console.WriteLine(R);
    }
}

