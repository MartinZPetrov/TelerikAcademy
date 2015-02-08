using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OneAndZeros
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        for (int i = 0; i < 5; i++)
        {
            for (int j = 15; j >= 0; j--)
            {
                bool isBitOne = ((1 << j) & n) > 0;
                if (isBitOne)
                {
                    switch (i)
                    {
                        case 0:
                        case 2:
                        case 3:
                            Console.Write(".#.");
                            break;
                        case 1:
                            Console.Write("##.");
                            break;
                        case 4:
                            Console.Write("###");
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                        case 4:
                            Console.Write("###");
                            break;
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("#.#");
                            break;
                    }
                }

                if (j > 0)
                {
                    Console.Write(".");
                }
            }

            Console.WriteLine();
        }
    }
}

