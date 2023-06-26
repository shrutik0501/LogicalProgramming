using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class CouponNumber
    {
        public static void getCoupan()
        {
            Console.WriteLine("enter the distinct number of elements you have");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("enter " + size + " distinct element");
            for (int i = 0; i < size; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("enter the lowest number of your list");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the highest number of your list");
            int max = Convert.ToInt32(Console.ReadLine());
            //int range = max - min;
            int x = size;
            int count = 0;
            Random r = new Random();
            while (x != 0)
            {
                int getr = r.Next(min, max + 1);
                for (int i = 0; i < x; i++)
                {
                    if (a[i] == getr)
                    {
                        if (x != 1)
                        {
                            for (int j = i; j < x - 1; j++)
                                a[j] = a[j + 1];
                            x--;
                            break;
                        }
                        else
                        {
                            x--;
                        }
                    }
                }
                count++;
            }
            Console.WriteLine("The number of times taken by random process to generate all the coupon is: " + count);
        }

    }
}
    

