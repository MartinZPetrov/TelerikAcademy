using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Problem 16.** Bit Exchange (Advanced)

//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
//The first and the second sequence of bits may not overlap.
//Examples:

//n	            p	q	k	binary representation of n	            binary result	                    result
//1140867093	3	24	3	01000100 00000000 01000000 00010101	    01000010 00000000 01000000 00100101	1107312677
//4294901775	24	3	3	11111111 11111111 00000000 00001111	    11111001 11111111 00000000 00111111	4194238527
//2369124121	2	22	10	10001101 00110101 11110111 00011001	    01110001 10110101 11111000 11010001	1907751121
//987654321	    2	8	11	-	-	overlapping
//123456789	    26	0	7	-	-	out of range
//33333333333	-1	0	33	-	-	out of range

class BitExchangeAdanvced
{
    static void Main()
    {
        //tested withe data from previous task 
        int p, q, k, num;
        int counter = 31;
        Console.Write("p: ");
        p = Int32.Parse(Console.ReadLine());
        Console.Write("q: ");
        q = Int32.Parse(Console.ReadLine());
        Console.Write("k: ");
        k = Int32.Parse(Console.ReadLine());
        Console.Write("num : ");
        num = Int32.Parse(Console.ReadLine());
        if (p < q && (k + q) <= 32) // check if correct data was entered
        {
            string numBinary = Convert.ToString(num, 2).PadLeft(32, '0');
            Console.WriteLine(numBinary);
            char[] array = new char[numBinary.Length];
            for (int i = 0; i < 32; i++)
            {
                array[i] = numBinary[counter]; //we want the bits from right to left
                counter--;
            }
            for (int i = 0; i < k; i++)
            {
                char t = array[q]; // swap the bits in the required postions
                array[q] = array[p];
                array[p] = t;
                q++;
                p++;
            }
            for (int i = 31; i >= 0; i--) // display the bits in correct form
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Wrong input data");
        }
    }
}

