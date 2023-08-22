using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Even_or_odd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num % 2 == 0 )
            {
                Console.WriteLine("Number is even number");
            }
            else
            {
                Console.WriteLine("Number is odd number");
            }
        }
    }
}
