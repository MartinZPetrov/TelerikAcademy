using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tak07
{
    public delegate void MyDel();
    public class Timer
    {
        public int Interval { get; set; }

        public MyDel DelHandler { get; set; }

        public Timer(int inerval)
        {
            Interval = inerval;
        }

        public void execute()
        {
            while(true)
            {
                this.DelHandler();
                Thread.Sleep(this.Interval * 1000);  
            }
        }



    }
}
