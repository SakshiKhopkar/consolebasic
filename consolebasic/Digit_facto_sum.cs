using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Digit_facto_sum
    {
        // 1!+2!+3!
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num1=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for (int i = 1; i <= num1; i++)
            {
                fact = fact * i;
                sum = sum + fact;
            }
            Console.WriteLine(sum);
        }
    }
}
