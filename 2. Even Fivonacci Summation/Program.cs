using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Even_Fivonacci_Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            int num2 = 2;
            int temp;
            int max = 4000000;
            int sumNum = 0;
            int testCounter = 2;

            while (!(num2 > max))
            {
                if ((num2 % 2) == 0)
                {
                    sumNum += num2;
                }
                temp = num2;
                num2 = num2 + num1;
                num1 = temp;
                testCounter++;
            }
            Console.WriteLine(sumNum);
            Console.ReadLine();
        }
    }
}
