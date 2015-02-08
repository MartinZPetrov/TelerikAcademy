using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.
//Examples:

//n	binary representation	p	bit @ p
//5	00000000 00000101	2	1
//0	00000000 00000000	9	0
//15	00000000 00001111	1	1
//5343	00010100 11011111	7	1
//62241	11110011 00100001	11	0

class ExtractBitFromInt
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter positive number");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of the bit too get");
        int pos = Int32.Parse(Console.ReadLine());

        int mask = 1 << pos;
        int andMask = number & mask;
        int bit = andMask >> pos;
        Console.WriteLine("i={0}; b={1} -> value={2}", number, pos, bit);

    }
}

