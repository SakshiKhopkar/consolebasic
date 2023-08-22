using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class PatternABCDrev
    {
        static void Main(string[] args)
        {
            for(char i = 'D'; i >= 'A'; i--)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
