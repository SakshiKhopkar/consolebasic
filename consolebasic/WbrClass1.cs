﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolebasic
{
    internal class WbrClass1
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 20)
            {
                
                if(i %3 == 0 && i % 5 ==0) {
                    i++;
                    continue;
                }
                Console.WriteLine(i);
                i++;
            }
        }
    }
}
