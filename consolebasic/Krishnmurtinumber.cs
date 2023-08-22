using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    //145-> 1!+4!+5!=145
    internal class Krishnmurtinumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int factsum = 0;
            while (num>0)
            {
                int rem = num % 10;
                int fact = 1;
                for (int j = 1; j <= rem; j++)
                {
                    fact = fact * j;
                }
                factsum = factsum + fact;
                num = num / 10;
            }
           if (factsum == temp)
            {
                Console.WriteLine("number is krishnmurti");
            }
           else
            {
                Console.WriteLine("number is not krishnamurti");
            }
        }
    }
}
