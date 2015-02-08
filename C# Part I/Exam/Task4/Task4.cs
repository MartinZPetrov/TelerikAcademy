using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task4
{
    static void Main()
    {
        int N = Int32.Parse(Console.ReadLine());
        int Width = N * 2 - 1;
        int leftnakCounter = 0;
        int leftWhiteSpaceCounter = N - 1;
        int rightXCounter = 0;
        int rightNakCounter = N - 3;

        for (int i = 0; i < N - 1; i++)
        {
            if (i == 0)
            {
                Console.Write(new string(' ', N - 1));
                Console.Write(new string(':', 1));
                Console.Write(new string(':', N - 1));
                leftWhiteSpaceCounter--;
                leftnakCounter++;
                Console.WriteLine();
            }
            else if (i == 1)
            {
                Console.Write(new string(' ', leftWhiteSpaceCounter));
                Console.Write(new string(':', 1));
                Console.Write(new string('/', leftnakCounter));
                Console.Write(new string('/', rightNakCounter));
                Console.Write(new string(':', 2));
                leftnakCounter++;
                leftWhiteSpaceCounter--;
                rightNakCounter--;
                rightXCounter++;
                Console.WriteLine();
            }
            else
            {
                Console.Write(new string(' ', leftWhiteSpaceCounter));
                Console.Write(new string(':', 1));
                Console.Write(new string('/', leftnakCounter));
                Console.Write(new string('/', rightNakCounter));
                Console.Write(new string(':', 1));
                Console.Write(new string('X', rightXCounter));
                Console.Write(new string(':', 1));
                leftnakCounter++;
                leftWhiteSpaceCounter--;
                rightNakCounter--;
                rightXCounter++;
                Console.WriteLine();

            }
        }

        Console.Write(new string(':', N));
        Console.Write(new string('X', N - 2));
        Console.WriteLine(new string(':', 1));
        rightXCounter = N - 2 - 1;
        int rightWhiteSpaceCounter = 1;
        
        for (int i = 0; i < N - 1; i++)
        {
            if (rightXCounter == -1)
            {
                Console.Write(new string(':', N));
            }
            else if (rightXCounter == 0)
            {
                Console.Write(new string(':', 1));
                Console.Write(new string(' ', N - 2));
                Console.Write(new string(':', 1));
                Console.WriteLine(new string(':', 1));
                rightXCounter--;
            }
            else
            {
                Console.Write(new string(':', 1));
                Console.Write(new string(' ', N - 2));
                Console.Write(new string(':', 1));
                Console.Write(new string('X', rightXCounter));
                Console.Write(new string(':', 1));
                Console.WriteLine(new string(' ', rightWhiteSpaceCounter));
                rightWhiteSpaceCounter++;
                rightXCounter--;
            }
        }
    }
}

