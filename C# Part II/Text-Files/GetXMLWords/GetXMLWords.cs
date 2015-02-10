/*Write a program that extracts from given XML file all the text without the tags. Example:
<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3">
 * <interest> Games</instrest><interest>C#</instrest><interest> Java</instrest></interests></student>
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

class GetXMLWords
{
    static void Main()
    {

       
        using (StreamReader sr = new StreamReader("test.xml"))
        {
            string line;
            string words = string.Empty;
            while ((line = sr.ReadLine()) != null)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == '<')
                    {
                        while (line[i] != '>')
                        {
                            i++;
                            continue;
                        }
                    }
                    else
                    {
                        words += line[i];
                        if (line[i +1] == '<')
                        {
                            Console.WriteLine(words);
                            words = "";
                        }
                    }
                }
            }
        }
    }
}

