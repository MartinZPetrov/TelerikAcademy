/*Write a program that finds all prime numbers in 
*the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SieveOfEratosthenes
{
    static void Main(string[] args)
    {

        int numbers = 10000000;
        bool[] prime = new bool[numbers];

        for (int i = 0; i < numbers; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i < numbers; i++)
        {
            if (prime[i] == true)
            {
                for (int j = 2; j * i< numbers; j++)
                {
                    prime[i * j] = false;
                }
                
            }   
        }

        for (int i = 2; i < numbers; i++)
        {
            if (prime[i])
            {
                Console.Write(i + " ");
            }
        }
    }
}

