using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Pattern_of_sqr
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                if (i == 0 || i == 4)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();

                if (i >= 1 && i <= 3)
                {
                    for (int j = 0; j <= 4; j++)
                    {
                        if (j == 0 || j == 4)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 1 && j <= 3)
                        {
                            Console.Write(" ");
                        }

                    }
                    Console.WriteLine();

                }
            }
        }
    }
}
