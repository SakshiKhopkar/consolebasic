using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Automorphic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            int sqr =num*num;
            int temp = num;
            Console.WriteLine("square is" + sqr);
            int count = 0;
            while (num > 0)
            {
                count++;
                num =num / 10;
                
            }
            int power = 1;
            for (int i = 1; i <= count; i++)
            {
                power = power *10;
            }
            bool isauto=true;
            while (sqr > 0)
            {
                int rem=sqr % power;
                if (rem != temp)
                {
                    isauto = false;
                    break;

                }
                sqr = sqr  / power;
            }
            if (isauto)
            {
                Console.WriteLine("is automorphic");
            }
            else
            {
                Console.WriteLine("not automorphic");
            }
        }
    }
}
