using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Kaprekar_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int sqr = num * num;
            int copy = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i = 1;i<=count;i++)
            {
                power = power * 10;
            }
            int end = sqr % power;
            int start = sqr / power;
            int sum = end + start;
            if(sum == copy)
            {
                Console.WriteLine("number is kaprekar number");
            }
            else
            {
                Console.WriteLine("number is not kaprekar number");
            }
        }
    }
}
