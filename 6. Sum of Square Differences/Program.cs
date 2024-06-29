using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Sum_of_Square_Differences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumSquares = 0;
            for (int i = 1; i < 101; i++)
            {
                sumSquares += Math.Pow(i, 2);
            }
            double squaredSum = 0;
            for (int i = 1;i < 101; i++)
            {
                squaredSum += i;
            }
            squaredSum = Math.Pow(squaredSum, 2);
            Console.WriteLine((squaredSum - sumSquares).ToString());
            Console.ReadLine();
        }
    }
}
