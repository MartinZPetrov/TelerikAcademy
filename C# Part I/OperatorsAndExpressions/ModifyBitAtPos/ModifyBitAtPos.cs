using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
//Examples:

//n	binary representation of n	p	v	binary result	result
//5	    00000000 00000101		2	0   000000 00000001	    1
//0 	00000000 00000000		9	1   000010 00000000	    512
//15	00000000 00001111		1	1   0000000 00001111	15
//5343	00010100 11011111		7	0   0010100 01011111	5215
//62241	11110011 00100001		11	0   1110011 00100001	62241

class ModifyBitAtPos
{
    static void Main()
    {

        int n = 0;
        int p = 9;
        int mask = 1 << p; ;
        int orMask = n | mask; // set bit to 1
        string nBinary, mBinary;
        nBinary = Convert.ToString(n, 2);
        mBinary = Convert.ToString(orMask, 2).PadLeft(8, '0');
        Console.WriteLine("n = {0} ({1}), p={2}, v=1 ->{3} ({4})", n, nBinary, p, orMask, mBinary);

        n = 62241;
        p = 11;
        mask = ~(1 << p);
        orMask = n & mask; // set bit to 0
        nBinary = Convert.ToString(n, 2);
        mBinary = Convert.ToString(orMask, 2).PadLeft(8, '0');
        Console.WriteLine("n = {0} ({1}), p={2}, v=0 ->{3}  ({4})", n, nBinary, p, orMask, mBinary);
    }
}

