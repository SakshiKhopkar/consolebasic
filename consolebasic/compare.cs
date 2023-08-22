using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class compare
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            num1 = 20;
            num2=10;
            num3 = 40;
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine(" greater number is "+num1);
                }
                else { Console.WriteLine("greater number is "+num3); }
            }
            else if (num2 > num3) 
            {
                Console.WriteLine("greater number is"+num2);
            }
            else
            {
                Console.WriteLine("greater number is "+num3);
            }
        }
    }
}
