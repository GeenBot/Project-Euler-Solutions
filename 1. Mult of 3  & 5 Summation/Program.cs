using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Mult_of_3____5_Summation
{
    internal class Program
    {
        //Sum together all numbers from 0 to 1000 non-inclusive that are either a multiple of 3 or 5.
        static void Main(string[] args)
        {
            int value = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (((i % 3) == 0) | ((i % 5) == 0)) {
                    value += i;
                }
            }
            Console.WriteLine(value.ToString());
            Console.ReadLine();
        }
        
    }
}
