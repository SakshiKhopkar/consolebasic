using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Factrorial_Avg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter num");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sum = 0;
            for(int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                    count++;
                }
            }
            int avg = sum / count;
            Console.WriteLine(avg);
        }
    }
}
