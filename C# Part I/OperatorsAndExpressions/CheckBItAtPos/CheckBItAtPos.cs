using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
//Examples:
//n	binary representation of n	p	bit @ p == 1
//5	00000000 00000101	2	true
//0	00000000 00000000	9	false
//15	00000000 00001111	1	true
//5343	00010100 11011111	7	true
//62241	11110011 00100001	11	false
class CheckBItAtPos
{
    static void Main()
    {

        Console.WriteLine("Enter positive number");
        int number = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter position of the bit too get");
        int pos = Int32.Parse(Console.ReadLine());

        int mask = 1 << pos;
        int andMask = number & mask;
        int bit = andMask >> pos;
        bool isEquall = bit == 1;
        Console.WriteLine("{0}  {1} {2} {3}", number, Convert.ToString(number, 2), pos, isEquall);
    }
}

