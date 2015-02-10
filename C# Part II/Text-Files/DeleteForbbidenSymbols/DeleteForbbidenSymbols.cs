//Write a program that deletes from a text file all words that start with the prefix "test". Words contain only the symbols 0...9, a...z, A…Z, _.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class DeleteForbbidenSymbols
{
    static void Main(string[] args)
    {
       
        using (StreamWriter sw = new StreamWriter("output.txt"))
        {
            using (StreamReader sr = new StreamReader("test.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.ToLower();
                    line = Regex.Replace(line, @"\btest\w*\b",string.Empty);
                    sw.WriteLine(line);
                }
            }
        }
    }
}
