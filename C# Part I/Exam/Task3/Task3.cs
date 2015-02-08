using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class Task3
{
    static void Main(string[] args)
    {
        BigInteger number = BigInteger.Parse(Console.ReadLine());
        string strNumber = number.ToString();
        int transformCounter = 0;
        BigInteger sum = 0;
        BigInteger productOfSums = 1;
        bool valueFound = false;

        while (true)
        {
            if (strNumber.Length == 0)
            {
                break;
            }

            strNumber = strNumber.Substring(0, strNumber.Length - 1);
            
            for (int j = 0; j < strNumber.Length; j++)
            {
                if (j % 2 == 0)
                {
                    sum += Int32.Parse(strNumber[j].ToString());
                }
            }

            if (strNumber.Length != 0)
            {
                productOfSums *= sum;
                sum = 0;
            }

            if (strNumber.Length == 0)
            {
                strNumber = productOfSums.ToString();
                transformCounter++;
                productOfSums = 1;
                sum = 0;

                if (transformCounter == 10)
                {
                    Console.WriteLine(strNumber);
                    valueFound = true;
                    break;
                }

                if (strNumber.Length == 1)
                {
                    break;
                }
            }
        }

        if (!valueFound)
        {
            Console.WriteLine(transformCounter);
            Console.WriteLine(strNumber);
        }
    }
}

