using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Sqrtseries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers in series");
            int num1=Convert.ToInt32(Console.ReadLine());
           // int f1 = 1;
            int i = 1;
            while ( i<=num1)
            {
                int f1 = i * i;
                Console.WriteLine(f1);
                i++;
            }
        }
    }
}
