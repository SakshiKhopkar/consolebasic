using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class Table_from_1to10
    {
        static void Main(string[] args)
        { 
        for (int NUM = 1;NUM<=10;NUM++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int t = i * NUM;
                    Console.Write(t);
                }
                Console.WriteLine(); 
            }
        }
    }
}
