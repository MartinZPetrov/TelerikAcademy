//Write a program that calculates N!/K! for given N and K (1<K<N).
using System;

class FactorialDividedByFacotial
{
    static void Main()
    {
        double nFact, kFact, answer;
        kFact = 1;
        nFact = 1;
        int k, n;
        Console.Write("N: ");
        n = Int32.Parse(Console.ReadLine());
        Console.Write("K: ");
        k = Int32.Parse(Console.ReadLine());
        if (k > 1 && k < n)
        {
            for (int i = n; i > 1; i--)
            {
                nFact *= i;
            }

            for (int i = k; i > 1; i--)
            {
                kFact *= i;
            }
            answer = nFact / kFact;
            Console.WriteLine("{0}!/{1}! = {2}", n, k, answer);
        }
        else
        {
            Console.WriteLine("The sequence must be (1<K<N)");
        }
      
    }
}

