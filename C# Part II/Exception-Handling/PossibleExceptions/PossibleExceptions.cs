using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class PossibleExceptions
{
    static void Main(string[] args)
    {
        string fullPath = Console.ReadLine();
        try
        {
            Console.WriteLine(File.ReadAllText(fullPath));
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message); //get exception type and user friendly message
        }
    
    }
}

