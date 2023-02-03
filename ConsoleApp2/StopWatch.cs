using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class StopWatch
    {
        public static void StartStopwatch()
        {

            // Create new stopwatch

            Stopwatch stopwatch = new Stopwatch();

            // Time Start
            Console.WriteLine("Press Enter for start");
            Console.ReadLine();
            stopwatch.Start();

            // Time Stop
            Console.WriteLine("Press Enter for stop");
            Console.ReadLine();
            stopwatch.Stop();
            Console.WriteLine("Time Elapsed : {0}", stopwatch.Elapsed);
        }
    }
}
