using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NightmareonCode
{
    static void Main()
    {
        string number =  Console.ReadLine();
        decimal sum = 0;
        decimal count = 0;

        for (int i = 0; i < number.Length; i++)
        {
            if ((i % 2) == 1)
            {
                int current;
                if (int.TryParse(number[i].ToString(), out current))
                {
                    sum += current;
                    count++;
                }
            }
        }
        Console.WriteLine("{0} {1} ", count, sum);
    }
}

