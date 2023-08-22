using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    //Number is greater than 5 or not
    internal class Greater_Than5_ornot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 5)
            {
                Console.WriteLine("number is greater than 5");
            }
            else
            {
                Console.WriteLine("number is not greater than 5");
            }
        }
    }
}
