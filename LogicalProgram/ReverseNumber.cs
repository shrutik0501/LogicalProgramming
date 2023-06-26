using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class ReverseNumber
    {
        public static void reverseNumber()
        {
            Console.WriteLine("enter a number to reverse:");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                Console.Write(number % 10);
                number = number / 10;
            }
        }
    }
}

