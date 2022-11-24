using System;
using System.Threading;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace PomoTimer
{
    class Program
    {
        private int _workDuration;

        public int WorkDuration
        {
            get { return _workDuration; }
            set { _workDuration = value; }
        }
        static void Main(string[] args)
        {
            Timesec time = new();
            time.TimeCount();
           

        }

        
    }
}
