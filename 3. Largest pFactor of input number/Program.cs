using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Largest_pFactor_of_input_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //600851475143
            double fNumber = Convert.ToInt64(Console.ReadLine());
            double counter = 2;

            while (1 == 1) 
            {
                if ((fNumber % counter) == 0)
                {
                    if ((fNumber / counter) != 1)
                    {
                        fNumber = fNumber / counter;
                    } else
                    {
                        Console.WriteLine(fNumber.ToString());
                        break;
                    }
                } else
                {
                    counter++;
                }
                
            }
            Console.ReadLine();
        }
    }
}
