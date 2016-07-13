using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task08
{
    public delegate void TimerEventHandler(object sender, SampleArgs args);

    public class TimerPublisher
    {
        public event TimerEventHandler RaiseTimer;
    
        public void Start(int ticks, int interval)
        {
            int start = 0;
            while (start <= interval)
            {
                Thread.Sleep(start * 1000);
                start += ticks;
                OnRaiseTimerEvent();
            }
        }


        protected void OnRaiseTimerEvent()
        {
            TimerEventHandler e = RaiseTimer;
           
            if (e != null)
            {
                e(this, new SampleArgs(DateTime.Now.ToString()));
            }
        }
    }

}
