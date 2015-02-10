//Write a program that deletes from given text file all odd lines. The result should be in the same file.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

class DeleteOddLines
{
    static void Main()
    {

        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                int counter = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    counter++;
                    if ((counter & 1) == 1) // check if odd
                    {
                        sw.WriteLine(line);
                    }
                }
            }
        }
        using (StreamWriter sw = new StreamWriter("test.txt"))
        {
            using (StreamReader sr = new StreamReader("output.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sw.WriteLine(line);
                }
            }
        }
    }
}


