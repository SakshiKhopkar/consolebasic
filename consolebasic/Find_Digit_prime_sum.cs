using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Find_Digit_prime_sum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while(num > 0)
            {
                int rem = num % 10;
                bool isprime = true;
                for (int i = 2; i < rem; i++)
                {
                    if (rem % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                       sum = sum + rem;
                }
               num = num / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
