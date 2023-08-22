using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Nprime_between1to50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value of n");
            int n= Convert.ToInt32(Console.ReadLine());
            int count = 0;
                for (int i = 1; i <= 50; i++)
                {
                    bool isprime = true;
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isprime = false;
                            break;
                        }
                    }
                    if (isprime)
                    {
                        count++;
                        Console.WriteLine(i);
                    }
                    if(count == n)
                    {
                    break;
                    }
                }
            


        }
    }
}
