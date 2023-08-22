using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class PatternSpacestar2
    {
        static void Main(string[] args)
        {
            for (int i = 4; i >= 1; i--)//row
            {
                for (int k = 3; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)//column
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
