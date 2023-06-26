using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number to Execute That UC");
            int UseCaseNumber =Convert.ToInt32(Console.ReadLine());
            switch (UseCaseNumber)
            {
                case 1:
                    Console.WriteLine("UC1 Executing");
                    FibonacciSeries.findFibonacciSeries(8);
                    break;
                    case 2:
                    Console.WriteLine("UC2 Executing");
                    PerfectNumber.checkPerfectNumber();
                    break;
                    case 3:
                    Console.WriteLine("UC3 Executing");
                    PrimeNumber.checkPrimeNumber();
                    break;
                    case 4:
                    Console.WriteLine("UC4 Executing");
                    ReverseNumber.reverseNumber();
                    break;
                    case 5:
                    Console.WriteLine("UC5 Executing");
                    CouponNumber.getCoupan();
                    break;
                    case 6:
                    Console.WriteLine("UC6 Executing");
                    StopWatch.stopWatchDemo();
                    break;
                    default:Console.WriteLine("Invalid Input");
                    break;

            }
            //FibonacciSeries.findFibonacciSeries(8);
            // PerfectNumber.checkPerfectNumber();
            // PrimeNumber.checkPrimeNumber();
            // ReverseNumber.reverseNumber();
            //CouponNumber.getCoupan();
            // StopWatch.stopWatchDemo();
        }
    }
}
