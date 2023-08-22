using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Print_and_sum
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
            while (i <= 10)
            {
             Console.WriteLine(i);
             sum = sum + i;
                i++;
            }
            Console.WriteLine("sum is ="+sum);
        }
    }
}
