using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Largest_Palindrome_Product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;
            string num = "";
            string temp = "0"; ;
            for (int i = 100; i < 1000; i++) {
                for (int j = 100; j < 1000; j++)
                {
                    num = (i * j).ToString();
                    if (num.Length == 5)
                    {
                        if (num.Substring(0, 2) == String.Join(null, num.Substring(3, 2).Reverse())) {
                            temp = num;
                        }
                    } else if (num.Length == 6)
                    {
                        if (num.Substring(0, 3) == String.Join(null, num.Substring(3, 3).Reverse()))
                        {
                            temp = num;
                        }
                    }
                    if (Convert.ToInt32(temp) > largest) {
                        largest = Convert.ToInt32(temp);
                    }

                }
            }
            Console.WriteLine(largest.ToString());
            Console.ReadLine();
        }
    }
}
