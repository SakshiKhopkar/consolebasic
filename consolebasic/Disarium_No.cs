using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Disarium_No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int psum = 0;
            int temp = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
             num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for (int i=1;i<=count;i++)
                {
                     power = power * digit;
                }
                psum = psum + power;
                count--;
                num = num / 10;

            }
            if (psum == temp)
            {
                Console.WriteLine("number is disarium number");
            }
            else
            {
                Console.WriteLine("number is not disarium number");
            }
        }

    }
}
