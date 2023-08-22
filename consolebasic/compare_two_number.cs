using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class compare_two_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > Num2)
            {
                Console.WriteLine("Num1 greater than Num2");
            }
            else
            {
                Console.WriteLine("Num2 is greater Number");
            }
        }
    }
}
