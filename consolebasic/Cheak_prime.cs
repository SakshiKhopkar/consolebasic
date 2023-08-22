using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Cheak_prime
    {
        static void Main(string[] args)
        {
            int a = 1;
            Console.WriteLine( "Enter the number");
            int num= Convert.ToInt32( Console.ReadLine() );
            for( int i = 2; i < num; i++ )
            {
                if(num%i == 0)
                {
                    a = 0;
                    break;
                }
            }
            if (a == 0) 
            {
                Console.WriteLine("NOT prime");
             }
            else { Console.WriteLine("prime"); }
        }
    }
}
