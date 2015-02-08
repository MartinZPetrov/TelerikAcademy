using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PeaceOFCake
{
    static void Main()
    {
        long A, B, C, D;
        A = Int32.Parse(Console.ReadLine());
        B = Int32.Parse(Console.ReadLine());
        C = Int32.Parse(Console.ReadLine());
        D = Int32.Parse(Console.ReadLine());



        long firstFraction = A / B;
        long SecondFraction = C / D;

        long domResult = B * D;
        long FirstFractionToMulipty = domResult / B;
        long SecondFractionToMltiply = domResult / D;
        long FirstResult = A * FirstFractionToMulipty;
        long SecondResult = C * SecondFractionToMltiply;
        long sum = FirstResult + SecondResult;
        string answer = sum.ToString() + "/" + domResult.ToString();

        decimal result =  sum / (decimal)domResult;
        
        if(result >= 1)
        {
            Console.WriteLine("{0}", (long)result);
            Console.WriteLine(answer);
       
        }
        else
        {
            Console.WriteLine("{0:f22}", result);
            Console.WriteLine(answer);
        
        }
      
    }

}

