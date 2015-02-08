using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Task1
{
    static void Main(string[] args)
    {
        int N = Int32.Parse(Console.ReadLine());
        int S = Int32.Parse(Console.ReadLine());
        double P = double.Parse(Console.ReadLine());
        int sheetsOfPapaer = N * S;
        double reams = sheetsOfPapaer / 500d;
        double result = reams * P;
        Console.WriteLine("{0:F2}",result);
    }
}

