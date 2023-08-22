using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Armstrong_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the digits in the number");
            int count= Convert.ToInt32(Console.ReadLine());
            int temp = num;    
            int sum = 0;
            while(num > 0)
            {
                int rem = num % 10;
                sum += (int)Math.Pow(rem, count);
                num=num/ 10;
            }
            if (sum == temp)
            {
                Console.WriteLine("it is arms");
            }
            else
            {
                Console.WriteLine("int is not arm");
            }
        }
    }
}
