using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AngyFemaleGPS
{
    static void Main()
    {

        decimal n = decimal.Parse(Console.ReadLine());

        string nTostring = n.ToString();
        int sumOdd = 0;
        int sumEven = 0;
        for (int i = 0; i < nTostring.Length; i++)
        {
            if(Char.IsDigit(nTostring[i]))
            {
                if (Convert.ToInt32(nTostring[i]) % 2 == 0)
                {
                    sumEven += Convert.ToInt32(nTostring[i] - 48);
                }
                else
                {
                    sumOdd += Convert.ToInt32(nTostring[i] - 48);
                }
            }
        }
        if(sumOdd > sumEven)
        {
            Console.WriteLine("left {0}", sumOdd);
        }
        else if( sumOdd < sumEven)
        {
            Console.WriteLine("right {0}", sumEven);
        }
        else
        {
            Console.WriteLine("straight {0}", sumEven);
        }

    }
}

