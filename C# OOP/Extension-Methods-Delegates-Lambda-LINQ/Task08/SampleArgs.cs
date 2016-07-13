using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08
{
    public class SampleArgs : EventArgs
    {
        private string message;
        public string Message
        {
            get { return this.message; }
            private set { this.message = value; }
        } 
        public SampleArgs(string messag)
        {
            Message = messag;
        }
    }
}
