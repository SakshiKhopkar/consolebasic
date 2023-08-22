using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class All_prime_between1to10
    {
        static void Main(string[] args)
        {
            int sum = 0;
           // bool isprime = true;
            for (int i = 2; i <= 20; i++)
            {
                bool isprime = true;
               for(int j = 2; j < i; j++)
               {
                   if(i % j ==0)
                    {
                        isprime = false;
                        break;
                    }
               }
               if (isprime == true)
                {
                    sum = sum + i;
                    Console.WriteLine(i);
                   // Console.WriteLine("sum is"+sum);
                }
            }
            Console.WriteLine("sum is" + sum);
           


        }
    }
}
