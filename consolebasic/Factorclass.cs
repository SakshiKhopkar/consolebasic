using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Factorclass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number" );
            int num=Convert.ToInt32( Console.ReadLine() );
            //int fact = 1;
            int i = 1;
            while( i <= num )//12
            {
                //int fact = num % i;//1
                if( num %i==0 )
                {
                    Console.WriteLine(i);
                }
                i++;

            }
        }
    }
}
