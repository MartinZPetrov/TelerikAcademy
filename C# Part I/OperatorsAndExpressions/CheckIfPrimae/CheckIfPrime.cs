//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
using System;
class CheckIfPrime
{
    static void Main()
    {
        int n;
        bool isNum, isPrime;
        isPrime = true;
        Console.Write("N: ");
        isNum = Int32.TryParse(Console.ReadLine(), out n);
        if (isNum)
        {
            if (n > 0 && n < 100)
            {
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("{0} is Prime", n);
                }
                else
                {
                    Console.WriteLine("{0} is not prime", n);
                }
            }
            else
            {
                Console.WriteLine("Please enter a number between 0 and 100");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 0 and 100");
        }

    }
}

