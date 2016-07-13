using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GSMTest
    {
        public static Random rnd = new Random();
        public static string[,] manafacturers = 
           {
            {"Nokia", "Samsung", "Motorola", "Sony", "HTC"},
            {"Lumia", "Galaxy Note", "Nexus 6", "Xperia", "One"},
            
        };

        public static string[] owners = { "Pencho", "Gencho", "Atanas", "I az" };

        public static Battery[] batteries =
        {
            new Battery(), new Battery("Better", 250, 25, BatteryType.LiIon),
            new Battery("Bad", 50, 5, BatteryType.NiCd), new Battery("TestModel", 300, 30, BatteryType.NiMH)
        };


        public static Display[] displays = { new Display(), new Display(4, 1000), new Display(5.5, 10000000) };


        public static GSM[] GenerateGSMs(int number)
        {
            GSM[] gsms = new GSM[number];

            for (int i = 0; i < number; i++)
            {
                int col = rnd.Next(0, manafacturers.GetLength(1));
                int row = rnd.Next(0, manafacturers.GetLength(0));

                gsms[i] = new GSM(manafacturers[0, col], manafacturers[row, col], rnd.Next(0, 2001),
                    owners[rnd.Next(0, owners.Length)], batteries[rnd.Next(0, batteries.Length)],
                    displays[rnd.Next(0, displays.Length)]);
            }

            return gsms;
        }

        public static void PrintGSMsInfo(GSM[] gsms)
        {
            for (int i = 0; i < gsms.Length; i++)
            {
                Console.WriteLine("Sample GSM {0}: {1}", i + 1, gsms[i]);
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine("IPhone info: {0}", GSM.IPhone4S);
        }
    }
}
