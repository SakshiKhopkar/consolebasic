using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Harshad_No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while(num > 0)
            {
                int rem = num%10;
                sum=sum+rem;
                num = num / 10;
            }
            if(temp % sum==0)
            {
                Console.WriteLine("number is a harshad number");
            }
            else { Console.WriteLine("not harshad"); }
        }
    }
}
