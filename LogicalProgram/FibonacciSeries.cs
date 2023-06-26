using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class FibonacciSeries
    {
        public static void findFibonacciSeries(int count)
        {
            int firstNumber = 0;
            if (count >= 1)
            {
                Console.WriteLine(firstNumber);
            }
            int secondNumber = 1;
            if (count >= 2)
            {
                Console.WriteLine(secondNumber);
            }
            int nextNumber;
            for (int i = 2; i < count; i++)
            {
                nextNumber = firstNumber + secondNumber;
                Console.WriteLine(nextNumber);
                firstNumber = secondNumber;
                secondNumber = nextNumber;
            }
        }
    }
}
