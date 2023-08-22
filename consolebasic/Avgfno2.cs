using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Avgfno2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                count++;
                num = num / 10;
            }
            int avg = sum / count;
            Console.WriteLine("avg is =" + avg);

        }
    }
}
