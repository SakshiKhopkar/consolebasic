using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Avgfoddno_digit
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the total no of digit in no");
            int nd=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                if (rem % 2 != 0)
                {
                    sum = sum + rem;
                }
                num = num / 10;
            }
            double avg = (sum / nd);
            Console.WriteLine(avg);
        }
    }
}
