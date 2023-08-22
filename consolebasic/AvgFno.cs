using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class AvgFno
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num= Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            while (num != 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }
            double avg = sum / 3;
            Console.WriteLine("avg is =" + avg);
            
        }
    }
}
