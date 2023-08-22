using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class PatternClass5
    {
        static void Main(string[] args)
        { 
            {
                int number = 8, count = 1;
                count = number - 1;
                for (var k = 1; k <= number; k++)
                {
                    for (var i = 1; i <= count; i++)
                        Console.Write(" ");
                    count--;
                    for (var i = 1; i <= 2 * k - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                count = 1;
                for (var k = 1; k <= number - 1; k++)
                {
                    for (var i = 1; i <= count; i++)
                        Console.Write(" ");
                    count++;
                    for (var i = 1; i <= 2 * (number - k) - 1; i++)
                        Console.Write("*");
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
    }

