using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Duck_num
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num>0) 
            {
                int rem= num%10;
                if (rem == 0)
                {
                    Console.WriteLine("number is duck number");
                }
                num =num / 10;
            }
        }
    }
}
