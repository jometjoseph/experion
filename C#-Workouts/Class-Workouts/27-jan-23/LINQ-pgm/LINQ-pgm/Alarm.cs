using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_pgm
{
    internal class Alarm
    {
        public Alarm(int timeInterval, string message="Alarm") 
        {
            Thread.Sleep(timeInterval * 1000);
            Console.Beep();
        }

    }
}
