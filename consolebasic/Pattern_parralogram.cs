using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Pattern_parralogram
    {
        static void Main(string[] args)
        {
            int size = 4;
                for(int i=1; i<=size; i++)
            {
                for(int j=1; j < i; j++)
                {
                    Console.Write(" ");
                }
                for(int k=1; k<=size; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
