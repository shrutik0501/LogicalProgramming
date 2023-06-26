using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class StopWatch
    {
        public static void stopWatchDemo()
        {
            Console.WriteLine("enter 0 to start the stopwatch");
            int num = Convert.ToInt32(Console.ReadLine());
            var timer = new Stopwatch();
            if (num == 0)
            {
                timer.Start();
                Console.WriteLine("enter 1 to stop the stopwatch");
            }
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 1)
            {
                timer.Stop();
            }
            TimeSpan timeTaken = timer.Elapsed;
            Console.WriteLine("The elapsed time is : " + timeTaken.ToString());

        }
    }
}
    

