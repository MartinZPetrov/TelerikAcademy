using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class GameOfPage
{
    static void Main(string[] args)
    {
        int length = 16;
        char[,] cookiesPlase = new char[16, 16];
        for (int i = 0; i < length; i++)
        {
            string current = Console.ReadLine();
            for (int j = 0; j < length; j++)
            {
                cookiesPlase[i, j] = current[j];
            }
        }
        string currentAsk;

        while ((currentAsk = Console.ReadLine()) != "paypal")
        {

            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());


            if (currentAsk == "what is")
            {
                if(cookiesPlase[row,col] == '0')
                {
                    Console.WriteLine("Smile");
                }


            }
        }
    }

    private static int IsThatCooie()
}

