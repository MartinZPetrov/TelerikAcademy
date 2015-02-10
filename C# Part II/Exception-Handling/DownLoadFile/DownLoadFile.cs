/*Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) 
 * and stores it the current directory. Find in Google how to download files in C#. Be sure to catch
 * all exceptions and to free any used resources in the finally block.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


class DownLoadFile
{
    static void Main(string[] args)
    {
        try
        {
            using (WebClient Client = new WebClient())
            {
               // I have commented these operations. You can test with both ways. Currenlty its hardcoded.
               // Console.Write("Enter file address: ");
               // string fileAddress = Console.ReadLine();
               // Console.Write("Enter the item to download with extension (example Logo-BASD.jp) :");
               // string item = Console.ReadLine();
               // Client.DownloadFile(fileAddress, item);
                Client.DownloadFile("http://www.devbg.org/img/Logo-BASD.jpg", "Logo-BASD.jp");
            }

        }
        catch (Exception ex )
        {
            Console.WriteLine("Exception caught!\n{0}:{1}", ex.GetType().Name, ex.Message); //get exception type and user friendly message
        }

    }
}

