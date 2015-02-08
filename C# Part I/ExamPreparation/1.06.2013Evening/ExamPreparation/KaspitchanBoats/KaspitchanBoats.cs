using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class KaspitchanBoats
{
    static void Main(string[] args)
    {
        int n = Int32.Parse(Console.ReadLine());
        int width = n * 2 + 1;
        int height = 6 + ((n - 3) / 2) * 3;
        int sail = height * 2 / 3;
        int bottom = height * 1 / 3;
        string s = string.Empty;
        int sailStarPos = n + 1;
        for (int i = sail; i > 1; i--)
        {
            for (int j = 0; j < width / 2; j++)
            {
                if (j == i - 1)
                {
                    s += "*";
                }
                else
                {
                    s += ".";
                }

            }
            Console.Write(s);
            Console.Write("*");
            s = string.Empty;
            for (int k = width / 2; k > 0; k--)
            {

                if (k == i)
                {
                    s += "*";
                }
                else
                {
                    s += ".";
                }

            }
            Console.Write(s);
            s = string.Empty;
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', width));
        sailStarPos = 1;
        for (int i = 0; i < bottom -1; i++)
        {
            for (int j = 0; j < width / 2; j++)
            {
                if (j == sailStarPos)
                {
                    s += "*";
                }
                else
                {
                    s += ".";
                }

            }

            Console.Write(s);
            Console.Write("*");
            s = string.Empty;

            for (int k = width/2; k > 0; k--)
            {
                if (k == sailStarPos+1)
                {
                    s += "*";
                }
                else
                {
                    s += ".";
                }

            }
            Console.Write(s);
            s = string.Empty;
            Console.WriteLine();
            sailStarPos++;
        }
        Console.Write(new string('.', bottom)) ;
        Console.Write(new string('*', n));
        Console.Write(new string('.', bottom));
    }
}

